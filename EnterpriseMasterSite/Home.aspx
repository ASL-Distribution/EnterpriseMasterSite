<%@ Page Language="C#" MasterPageFile="~/EnterpriseMasterSite.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EnterpriseMasterSite.Home" %>
<asp:Content ID="content" ContentPlaceHolderID="cph" runat="server">
    <div>
        <asp:Label ID="alertL" runat="server" Text="" ForeColor="Red" Font-Bold="true" />
    </div>
    <div>
        <h2>
            Home
        </h2>        
    </div>
    <div>
        <asp:LinkButton ID="managementLB" runat="server" OnClick="managementLB_Click" Text="Management" />
        <br />
        <asp:LinkButton ID="reportingLB" runat="server" OnClick="reportingLB_Click" Text="Reporting" />
        <br />
        <asp:LinkButton ID="scanEventUtilityLB" runat="server" OnClick="scanEventUtilityLB_Click" Text="Reporting" />
    </div>
</asp:Content>