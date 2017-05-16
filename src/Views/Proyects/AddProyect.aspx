<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="AddProyect.aspx.cs" Inherits="lovis.Views.Proyects.AddProyect" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Add proyect
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Create proyect</h4>
                            <p class="category">Start managing your time</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Title</label>
                                        <asp:TextBox runat="server" ID="addp_title" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Summary</label>
                                        <asp:TextBox runat="server" ID="addp_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center">
                                <asp:Button runat="server" ID="addp_create" CssClass="btn btn-primary" OnClick="addp_create_Click" Text="Create proyect" />
                                <%--<button type="submit" class="btn btn-primary">Create proyect</button>--%>
                            </div>

                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
