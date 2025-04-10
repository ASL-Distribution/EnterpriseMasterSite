﻿using System;
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
            Response.Redirect("http://10.10.101.113/managementportal/landingpage.aspx?token=" + token);
        }

        protected void reportingLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/ReportingPortal/landingpage.aspx?token=" + token);
        }

        protected void scanEventUtilityLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/ScanEventUtility/landingpage.aspx?token=" + token);
        }

        protected void pickLabelLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/PickLabel/landingpage.aspx?token=" + token);
        }

        protected void exportingLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/ExportingPortal/Landingpage.aspx?token=" + token);
        }

        protected void notificationLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/NotificationPortal/Landingpage.aspx?token=" + token);
        }

        protected void containerLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/ContainerLabel/Landingpage.aspx?token=" + token);
        }

        protected void fileFlowLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/FileFlowWeb/Landingpage.aspx?token=" + token);
        }

        protected void trackAndTraceLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/TrackAndTrace/TrackAndTrace.aspx");
        }

        protected void ratingToolLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/RatingTool/Landingpage.aspx?token=" + token);
        }

        protected void packageRetrievalForShiptrackLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/PackageInfoRetrieval/Landingpage.aspx?token=" + token);
        }

        protected void skidTagLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/SkidTags/Landingpage.aspx?token=" + token);
        }

        protected void palletLabelLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/PalletLabels/Landingpage.aspx?token=" + token);
        }

        protected void publicAuthenticationLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.101.113/PublicAuthenticationPortal/Landingpage.aspx?token=" + token);
        }
    }
}