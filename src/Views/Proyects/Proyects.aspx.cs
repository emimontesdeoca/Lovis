using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects
{
    public partial class Proyects : System.Web.UI.Page
    {
        static int iClosed = 0;
        static int iBug = 0;
        static int iDefect = 0;
        static int iChanges = 0;
        static int iPatch = 0;
        static int iReview = 0;
        static int iFeature = 0;
        static int iSupport = 0;
        static int iDocumentation = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
            /// Someone tried to access this web without the correct id

            /// Get ID from URL
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('=');

            proyect_manage.NavigateUrl = "~/Views/Proyects/ManageProyect.aspx?id=" + splitnpu[1];

            /// Get project from ID
            Controllers.Proyects.Proyects cP = new Controllers.Proyects.Proyects();

            try
            {
                /// Get userlicence in common of this proyect and this user
                var query2 = (from lUL in Controllers.UserLicense.UserLicense.lUL
                              where lUL.IdUser == CU.Id && lUL.IdLicense == splitnpu[1]
                              select lUL).First();
                try
                {
                    /// If they are equal ( just in case someone paste another proyectID
                    var x = Controllers.Proyects.Proyects.lP.Single(a => a.IdLicense == splitnpu[1] && a.IdLicense == query2.IdLicense);

                    cP.Id = x.Id;
                    cP.IdLicense = x.IdLicense;
                    cP.Title = x.Title;
                    cP.Summary = x.Summary;
                    cP.Owner = x.Owner;
                    cP.Website = x.Website;
                    cP.Repository = x.Repository;
                    cP.Support = x.Support;

                    cP.Title = Security.CryptoUtils.DecodeElementString(cP, cP.Title);
                    cP.Summary = Security.CryptoUtils.DecodeElementString(cP, cP.Summary);
                    cP.Owner = Security.CryptoUtils.DecodeElementString(cP, cP.Owner);
                    cP.Website = Security.CryptoUtils.DecodeElementString(cP, cP.Website);
                    cP.Repository = Security.CryptoUtils.DecodeElementString(cP, cP.Repository);
                    cP.Support = Security.CryptoUtils.DecodeElementString(cP, cP.Support);


                    /// If everything works lets save Session
                    Session["Proyect"] = cP as Controllers.Proyects.Proyects;

                    Master.cpTITLE = cP.Title;
                }
                catch (Exception)
                {
                    /// GTFO
                    Session.Abandon();
                    Session.Clear();
                    Response.Redirect("/Views/Login/Login.aspx");

                }
            }
            catch (Exception)
            {
                Response.Redirect("/Views/Error/404.aspx");
            }

            /// Get current Proyect from the Session["Proyect"]
            //Controllers.Proyects.Proyects CP = Session["Proyect"] as Controllers.Proyects.Proyects;

            /// Set the summary on the view
            proyect_summary.InnerText = cP.Summary;
            proyect_website.Text = cP.Website;
            proyect_repository.Text = cP.Repository;
            proyect_support.Text = cP.Repository;
            proyect_website.NavigateUrl = cP.Website;
            proyect_repository.NavigateUrl = cP.Repository;
            proyect_support.NavigateUrl = cP.Website;
            proyect_newtask.NavigateUrl = "/Views/Element/AddElement.aspx?id=" + splitnpu[1];
            pagetitle.Text = cP.Title;

            /// Get the people from the proyect
            var query = (from lUL in Controllers.Users.Users.uLTest
                         join UL in Controllers.UserLicense.UserLicense.lUL on lUL.Id equals UL.IdUser
                         where UL.IdLicense == cP.IdLicense
                         select lUL).Distinct().ToList();

            StringBuilder sb = new StringBuilder();

            foreach (Controllers.Users.Users pU in query)
            {
                Controllers.Users.Users ppU = new Controllers.Users.Users();
                ppU.Username = Security.CryptoUtils.DecodeUsername(pU.Username);
                ppU.Name = Security.CryptoUtils.DecodeUserString(pU.Name, pU);
                ppU.Surname = Security.CryptoUtils.DecodeUserString(pU.Surname, pU);


                sb.AppendFormat("{0} {1}, ", ppU.Name, ppU.Surname);
            }

            sb.Remove(sb.Length - 2, 2);

            proyect_people.InnerText = sb.ToString();

            /// Elements load
            bugPanel.Text = BuildElement("Bug", splitnpu[1], cP, 1);
            defectPanel.Text = BuildElement("Defect", splitnpu[1], cP, 1);
            patchesPanel.Text = BuildElement("Patch", splitnpu[1], cP, 1);
            changesPanel.Text = BuildElement("Changes", splitnpu[1], cP, 1);
            featurePanel.Text = BuildElement("Feature", splitnpu[1], cP, 1);
            supportPanel.Text = BuildElement("Support", splitnpu[1], cP, 1);
            reviewPanel.Text = BuildElement("Review", splitnpu[1], cP, 1);
            documentationPanel.Text = BuildElement("Documentation", splitnpu[1], cP, 1);
            closedPanel.Text = BuildElement("", splitnpu[1], cP, 2);

        }


        private string BuildElement(string type, string splitnpu, Controllers.Proyects.Proyects cP, int state)
        {
            string res = "";

            var y = Controllers.Proyects.Proyects.lP.Single(a => a.IdLicense == splitnpu);

            var query3 = (from a in Controllers.Elements.Elements.lE
                          where a.IdProyect == y.Id
                          select a).OrderByDescending(d => d.DateCreation).ToList();

            StringBuilder sb = new StringBuilder();

            if (query3.Count > 0)
            {
                foreach (Controllers.Elements.Elements ea in query3)
                {
                    string a = Security.CryptoUtils.DecodeElementString(cP, ea.Type);
                    string b = Security.CryptoUtils.DecodeElementString(cP, ea.State);
                    string c = Security.CryptoUtils.DecodeElementString(cP, ea.Title);
                    string d = Security.CryptoUtils.DecodeElementString(cP, ea.Priority);
                    string f = Security.CryptoUtils.DecodeElementString(cP, ea.AssignedTo);

                    var u = Controllers.Users.Users.uLTest.Single(s => s.Id == f);
                    f = Security.CryptoUtils.DecodeUserString(u.Name, u) + " " + Security.CryptoUtils.DecodeUserString(u.Surname, u);

                    switch (state)
                    {
                        case 1:
                            if (a == type && b != "Closed")
                            {
                                sb.AppendFormat(@"<tr>");

                                /// Title
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", c);

                                /// Type
                                if (a == "Bug" || a == "Defect")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", a);
                                    if (a == "Bug")
                                    {
                                        iBug++;
                                    }
                                    else
                                    {
                                        iDefect++;
                                    }
                                }
                                else if (a == "Changes" || a == "Patch")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", a);
                                    if (a == "Changes")
                                    {
                                        iChanges++;
                                    }
                                    else
                                    {
                                        iPatch++;
                                    }
                                }
                                else if (a == "Review" || a == "Feature")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", a);
                                    if (a == "Review")
                                    {
                                        iReview++;
                                    }
                                    else
                                    {
                                        iFeature++;
                                    }
                                }
                                else if (a == "Support" || a == "Documentation")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-success"">{0}</span></td>", a);
                                    if (a == "Support")
                                    {
                                        iSupport++;
                                    }
                                    else
                                    {
                                        iDocumentation++;
                                    }
                                }

                                /// State
                                if (b == "New")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", b);
                                }
                                else if (b == "Analysis")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-default"">{0}</span></td>", b);
                                }
                                else if (b == "In-Progress")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-primary"">{0}</span></td>", b);
                                }
                                else if (b == "Resolved")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", b);
                                }
                                else if (b == "Test")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", b);
                                }
                                else if (b == "Closed")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-success"">{0}</span></td>", b);
                                }

                                /// Priority
                                if (d == "Low")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", d);
                                }
                                else if (d == "Normal")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-primary"">{0}</span></td>", d);
                                }
                                else if (d == "High")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", d);
                                }
                                else if (d == "Critical")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", d);
                                }

                                /// Assignation
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", f);

                                /// Dates
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateCreation);
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateStart);
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateFinish);

                                /// Button
                                sb.AppendFormat(@"<td class=""project-table"">");
                                sb.AppendFormat(@"<a href=""/Views/Element/ManageElement.aspx?id={0}"" class=""btn btn-primary btn-simple btn-xs"">", ea.Id);
                                sb.AppendFormat(@"<i class=""material-icons"">edit</i>");
                                sb.AppendFormat(@"</button>");
                                sb.AppendFormat(@"</td>");

                                sb.AppendFormat(@"</tr>");

                                res = sb.ToString();
                            }
                            break;
                        case 2:
                            if (b == "Closed")
                            {
                                sb.AppendFormat(@"<tr>");

                                /// Title                            
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", c);

                                /// Type                              
                                if (a == "Bug" || a == "Defect")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", a);
                                }
                                else if (a == "Changes" || a == "Patch")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", a);
                                }
                                else if (a == "Review" || a == "Feature")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", a);
                                }
                                else if (a == "Support" || a == "Documentation")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-success"">{0}</span></td>", a);
                                }

                                /// State
                                if (b == "New")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", b);
                                }
                                else if (b == "In-Progress")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-primary"">{0}</span></td>", b);
                                }
                                else if (b == "Resolved")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", b);
                                }
                                else if (b == "Test")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", b);
                                }
                                else if (b == "Closed")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-success"">{0}</span></td>", b);
                                }

                                /// Priority
                                if (d == "Low")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-info"">{0}</span></td>", d);
                                }
                                else if (d == "Normal")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-primary"">{0}</span></td>", d);
                                }
                                else if (d == "High")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-warning"">{0}</span></td>", d);
                                }
                                else if (d == "Critical")
                                {
                                    sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", d);
                                }

                                /// Assignation
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", f);

                                /// Dates
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateCreation);
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateStart);
                                sb.AppendFormat(@"<td class=""project-table"">{0}</td>", ea.DateFinish);

                                /// Button
                                sb.AppendFormat(@"<td class=""project-table"">");
                                sb.AppendFormat(@"<a href=""/Views/Element/ManageElement.aspx?id={0}"" class=""btn btn-primary btn-simple btn-xs"">", ea.Id);
                                sb.AppendFormat(@"<i class=""material-icons"">edit</i>");
                                sb.AppendFormat(@"</button>");
                                sb.AppendFormat(@"</td>");


                                sb.AppendFormat(@"</tr>");

                                iClosed++;
                                res = sb.ToString();
                            }
                            break;
                    }


                }
            }

            // Error message shown when theres is not task or whatever
            string txterror = @"<p class=""text-center"" style=""margin: 0 0 0 0;"">No task or issues found for this category.</p>";

            if (iBug == 0)
            {
                txtBug.Text = txterror;
                divBug.Visible = false;
            }
            if (iDefect == 0)
            {
                txtDefect.Text = txterror;
                divDefect.Visible = false;
            }
            if (iChanges == 0)
            {
                txtChanges.Text = txterror;
                divChanges.Visible = false;
            }
            if (iPatch == 0)
            {
                txtPatches.Text = txterror;
                divPatches.Visible = false;
            }
            if (iReview == 0)
            {
                txtReview.Text = txterror;
                divReview.Visible = false;
            }
            if (iFeature == 0)
            {
                txtFeature.Text = txterror;
                divFeatures.Visible = false;
            }
            if (iSupport == 0)
            {
                txtSupport.Text = txterror;
                divSupport.Visible = false;
            }
            if (iDocumentation == 0)
            {
                txtDocumentation.Text = txterror;
                divDocumentation.Visible = false;
            }
            if (iClosed == 0)
            {
                txtClosed.Text = txterror;
                divClosed.Visible = false;
            }

            return res;
        }

        protected void btn_edit_task(object sender, EventArgs e)
        {
            var btn = sender as System.Web.UI.HtmlControls.HtmlButton;

            var a = btn.Attributes["taskid"].ToString();

            Response.Redirect("/Views/Element/ManageElement.aspx?id=" + a);
        }


    }
}