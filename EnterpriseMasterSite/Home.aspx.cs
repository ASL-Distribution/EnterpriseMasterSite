using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnterpriseMasterSite.Auth;
using EnterpriseMasterSite.Database;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace EnterpriseMasterSite
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoUniversal();
            if (!IsPostBack)
            {
                DoFreshLoad();
            }
        }

        private void DoFreshLoad()
        {
            
        }

        private void DoUniversal()
        {
            alertL.Text = "";
        }

        protected void managementLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/managementportal/landingpage.aspx?token=" + token);
        }

        protected void reportingLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/reporting/reporting/landingpage.aspx?token=" + token);
        }

        protected void scanEventUtilityLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/ScanEventUtility/landingpage.aspx?token=" + token);
        }

        protected void pickLabelLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/PickLabelWeb/landingpage.aspx?token=" + token);
        }

        protected void exportingLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/Exporting/Exporting/Landingpage.aspx?token=" + token);
        }

        protected void notificationLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/NotificationPortal/Landingpage.aspx?token=" + token);
        }

        protected void containerLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/ContainerLabels/Landingpage.aspx?token=" + token);
        }

        protected void fileFlowLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/FileFlowUtility/FileFlowControlWebApplication/Landingpage.aspx?token=" + token);
        }

        protected void trackAndTraceLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/TT/TrackAndTrace.aspx");
        }
    }
}