<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="ManageProyect.aspx.cs" Inherits="lovis.Views.Proyects.Manage.ManageProyect" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Manage proyect
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Edit proyect</h4>
                            <p class="category">Complete your profile</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Title</label>
                                        <asp:TextBox runat="server" ID="mng_title" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Password</label>
                                        <asp:TextBox runat="server" ID="mng_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
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
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Remove proyect</h4>
                            <p class="category">Complete your profile</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Title</label>
                                        <asp:TextBox runat="server" ID="mng_del_title" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Summary</label>
                                        <asp:TextBox runat="server" ID="mgn_del_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Write title to confirm</label>
                                        <asp:TextBox runat="server" ID="mgn_del_confirm_title" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group label-floating">
                                        <div class="checkbox">
                                            <label>
                                                <input type="checkbox" runat="server" id="mng_del_checkbox" required />
                                                Confirm to delete the proyect.
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center">
                                <asp:Button runat="server" ID="Button1" CssClass="btn btn-primary" OnClick="addp_create_Click" Text="Create proyect" />
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
