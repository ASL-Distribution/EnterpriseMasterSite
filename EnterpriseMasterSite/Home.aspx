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
        <asp:LinkButton ID="scanEventUtilityLB" runat="server" OnClick="scanEventUtilityLB_Click" Text="Scan Event Utility" />
        <br />
        <asp:LinkButton ID="pickLabelLB" runat="server" OnClick="pickLabelLB_Click" Text="Pick Label Printing" />
        <br />
        <asp:LinkButton ID="exportingLB" runat="server" OnClick="exportingLB_Click" Text="Exporting" />
        <br />
        <asp:LinkButton ID="notificationLB" runat="server" OnClick="notificationLB_Click" Text="Notifications" />
        <br />
        <asp:LinkButton ID="containerLB" runat="server" OnClick="containerLB_Click" Text="Container Label Printing" />
        <br />
        <asp:LinkButton ID="fileFlowLB" runat="server" OnClick="fileFlowLB_Click" Text="File Flow Utility" />
        <br />
        <asp:LinkButton ID="trackAndTraceLB" runat="server" OnClick="trackAndTraceLB_Click" Text="Track and Trace" />
        <br />
        <asp:LinkButton ID="ratingToolLB" runat="server" OnClick="ratingToolLB_Click" Text="Rating Tool" />
        <br />
        <asp:LinkButton ID="packageRetrievalForShiptrackLB" runat="server" OnClick="packageRetrievalForShiptrackLB_Click" Text="Package Retrieval For Shiptrack" />
        <br />
        <asp:LinkButton ID="skidTagLB" runat="server" OnClick="skidTagLB_Click" Text="Skid Tag Printing" />
    </div>
</asp:Content>