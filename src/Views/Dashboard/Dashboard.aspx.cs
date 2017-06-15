using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Dashboard
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildCounters();


        }

        public void BuildCounters()
        {

            int newCounter = 0;
            int analysisCounter = 0;
            int inprogressCounter = 0;
            int resolvedCounter = 0;
            int testCounter = 0;
            int closedCounter = 0;

            Session["Proyect"] = null;

            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;

            /// Get proyects from user to build sidebar
            List<Controllers.Proyects.Proyects> CuLP = new List<Controllers.Proyects.Proyects>();
            foreach (Controllers.UserLicense.UserLicense UL in Controllers.UserLicense.UserLicense.lUL)
            {
                /// Find Userlicenses of user
                if (UL.IdUser == CU.Id)
                {
                    try
                    {
                        /// Finde License of UserLicense
                        var x = Controllers.License.License.lL.Single(l => l.IdLicense == UL.IdLicense);

                        /// Filter proyects for Licenses of user
                        foreach (Controllers.Proyects.Proyects P in Controllers.Proyects.Proyects.lP)
                        {
                            /// If userlicense and proyect licenese are == that means is our proyect
                            if (P.IdLicense == x.IdLicense)
                            {
                                CuLP.Add(P);
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            foreach (Controllers.Proyects.Proyects p in CuLP)
            {
                try
                {
                    var y = Controllers.Proyects.Proyects.lP.Single(a => a.IdLicense == p.IdLicense);

                    var query3 = (from a in Controllers.Elements.Elements.lE
                                  where a.IdProyect == y.Id
                                  select a).OrderByDescending(d => d.DateCreation).ToList();

                    foreach (Controllers.Elements.Elements ep in query3)
                    {
                        string a = Security.CryptoUtils.DecodeElementString(p, ep.State);
                        switch (a)
                        {
                            case "New":
                                newCounter++;
                                break;
                            case "Analysis":
                                analysisCounter++;
                                break;
                            case "In-Progress":
                                inprogressCounter++;
                                break;
                            case "Resolved":
                                resolvedCounter++;
                                break;
                            case "Test":
                                testCounter++;
                                break;
                            case "Closed":
                                closedCounter++;
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                }

            }

            /// Set values to counters in dashboard
            newTaskCounter.Text = newCounter.ToString();
            analysisTaskCounter.Text = analysisCounter.ToString();
            inprogressTaskCounter.Text = inprogressCounter.ToString();
            resolvedTaskCounter.Text = resolvedCounter.ToString();
            testTaskCounter.Text = testCounter.ToString();
            closedTaskCounter.Text = closedCounter.ToString();

            //BuildInfoSquares(CuLP);
        }

        public void BuildInfoSquares(List<Controllers.Proyects.Proyects> CuLP)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Controllers.Proyects.Proyects p in CuLP)
            {
                sb.AppendFormat(@"<div class=""col-lg-6 col-md-12"">");
                sb.AppendFormat(@"<div class=""card card-nav-tabs"">");
                sb.AppendFormat(@"<div class=""card-header"" data-background-color=""purple"">");
                sb.AppendFormat(@"<div class=""nav-tabs-navigation"">");
                sb.AppendFormat(@"<div class=""nav-tabs-wrapper"">");
                sb.AppendFormat(@"<h4 class=""dashboard-squares-title"">{0}</h4>",Security.CryptoUtils.DecodeElementString(p, p.Title));
                sb.AppendFormat(@"<ul class=""nav nav-tabs text-center dashboard-ul"" data-tabs=""tabs"">");
                sb.AppendFormat(@"<li class=""active"">");
                sb.AppendFormat(@"<a href=""#{0}"" data-toggle=""tab"">New<div class=""ripple-container""></div></a>", p.Id + "new");
                sb.AppendFormat(@"</li>");
                sb.AppendFormat(@"<li>");
                sb.AppendFormat(@"<a href=""#{0}"" data-toggle=""tab"">Analysis<div class=""ripple-container""></div></a>", p.Id + "anal");
                sb.AppendFormat(@"</li>");
                sb.AppendFormat(@"<li>");
                sb.AppendFormat(@"<a href=""#{0}"" data-toggle=""tab"">In-Progress<div class=""ripple-container""></div></a>", p.Id + "inpro");
                sb.AppendFormat(@"</li>");
                sb.AppendFormat(@"<li>");
                sb.AppendFormat(@"<a href=""#{0}"" data-toggle=""tab"">Resolved<div class=""ripple-container""></div></a>", p.Id + "res");
                sb.AppendFormat(@"</li>");
                sb.AppendFormat(@"<li>");
                sb.AppendFormat(@"<a href=""#{0}"" data-toggle=""tab"">Test<div class=""ripple-container""></div></a>", p.Id + "test");
                sb.AppendFormat(@"</li>");
                sb.AppendFormat(@"</ul>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"<div class=""card-content"">");
                sb.AppendFormat(@"<div class=""tab-content"">");


                List<string> listStates = new List<string>();


                listStates.Add("new");
                listStates.Add("anal");
                listStates.Add("inpro");
                listStates.Add("res");
                listStates.Add("test");

                foreach (string s in listStates)
                {
                    string state = "";
                    /// State
                    switch (s)
                    {
                        case "new":
                            state = "New";
                            break;
                        case "anal":
                            state = "Analysis";
                            break;
                        case "inpro":
                            state = "In-Progress";
                            break;
                        case "res":
                            state = "Resolved";
                            break;
                        case "test":
                            state = "Test";
                            break;
                    }

                    sb.AppendFormat(@"<div class=""tab-pane active"" id=""{0}"">", p.Id + s);
                    sb.AppendFormat(@"<table class=""table"">");
                    sb.AppendFormat(@"<tbody>");
                    sb.AppendFormat(@"<tr>");
                    sb.AppendFormat(@"<td class=""project-table""><b>Priority</b></td>");
                    sb.AppendFormat(@"<td class=""project-table""><b>Type</b></td>");
                    sb.AppendFormat(@"<td><b>Title</b></td>");
                    sb.AppendFormat(@"<td class=""td-actions text-right""><b>Edit</b></td>");
                    sb.AppendFormat(@"</tr>");

                    var query = (from a in Controllers.Elements.Elements.lE
                                 where a.IdProyect == p.Id && a.State == state
                                 select a).OrderByDescending(d => d.DateCreation).ToList();
                    /// Elements 
                    foreach (Controllers.Elements.Elements e in query)
                    {
                        sb.AppendFormat(@"<tr>");
                        string pr = "";
                        /// Priority
                        switch (e.Priority)
                        {
                            case "Low":
                                pr = "success";
                                break;

                            case "Medium":
                                pr = "primary";
                                break;

                            case "High":
                                pr = "warning";
                                break;

                            case "Critical":
                                pr = "danger";
                                break;

                        }
                        sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", pr);

                        string ty = "";
                        /// Type
                        switch (e.Type)
                        {
                            case "Bug":
                            case "Defect":
                                ty = "danger";
                                break;

                            case "Changes":
                            case "Patch":
                                ty = "warning";
                                break;

                            case "Review":
                            case "Feature":
                                ty = "info";
                                break;

                            case "Support":
                            case "Documentation":
                                ty = "success";
                                break;

                        }
                        sb.AppendFormat(@"<td class=""project-table""><span class=""label label-danger"">{0}</span></td>", ty);
                        /// Title
                        sb.AppendFormat(@"<td>{0}</td>", e.Title);
                        /// Button
                        sb.AppendFormat(@"<td class=""td-actions text-right"">");
                        sb.AppendFormat(@"<a href=""/Views/Element/ManageElement.aspx?id={0}"" class=""btn btn-primary btn-simple btn-xs"">", e.Id);
                        sb.AppendFormat(@"<i class=""material-icons"">edit</i>");
                        sb.AppendFormat(@"</td>");

                        sb.AppendFormat(@"</tr>");
                    }
                }


                sb.AppendFormat(@"</tbody>");
                sb.AppendFormat(@"</table>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"</div>");
                sb.AppendFormat(@"</div>");



            }
            squares.Text = sb.ToString();

        }
    }
}