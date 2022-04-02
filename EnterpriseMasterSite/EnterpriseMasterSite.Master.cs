using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnterpriseMasterSite.Auth;
using EnterpriseMasterSite.Database;

namespace EnterpriseMasterSite
{
    public partial class Enterprise : System.Web.UI.MasterPage
    {
        user user = null;
        string currentURL = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            DoUniversal();
            if (!IsPostBack)
            {
                DoFreshLoad();
            }
        }

        private void DoUniversal()
        {
            currentURL = HttpContext.Current.Request.Url.AbsoluteUri;
            if (currentURL.Contains("Login.aspx"))
            {
                if (Authentication.GetUser(this.Page) != null)
                {
                    Page.Response.Redirect("Home.aspx");
                }
                signoutB.Visible = false;
            }
            else
            {
                Authentication.Authenticate(this.Page);
                user = Authentication.GetUser(this.Page);
            }
        }

        private void DoFreshLoad()
        {
            
        }

        protected void signoutB_Click(object sender, EventArgs e)
        {
            Authentication.SignOut(this.Page);
        }
    }
}