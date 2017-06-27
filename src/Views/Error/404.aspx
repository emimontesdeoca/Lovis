<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="lovis.Controllers.Error._404" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Error - Lovis
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">
    <br />
    <br />
    <br />

    <h1 class="text-center">Error 404</h1>
    <br />
    <br />
    <p class="text-center">The page you entered could not be found.</p>
</asp:Content>
