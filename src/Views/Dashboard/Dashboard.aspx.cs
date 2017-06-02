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

            BuildInfoSquares(CuLP);
        }

        public void BuildInfoSquares(List<Controllers.Proyects.Proyects> CuLP)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"");

        }
    }
}