<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="AddElement.aspx.cs" Inherits="lovis.Views.Proyects.Element.AddElement" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Literal runat="server" ID="pagetitle"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content" style="padding: 5px 15px !important;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Create task</h4>
                            <p class="category">Start by creating task for your project</p>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h3 runat="server" id="adde_error" class="text-danger text-center">There was an error.</h3>
                            </div>
                        </div>
                        <div class="card-content">
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Initial information</legend>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4 col-sm-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Title</label>
                                            <asp:TextBox runat="server" ID="adde_title" MaxLength="40"  CssClass="form-control" required></asp:TextBox>
                                            <div class="help-block">E.g: Responsive not working. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Priority</label>
                                            <%--<asp:TextBox runat="server" ID="adde_priority" CssClass="form-control" required></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="adde_priority" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Critial. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">State</label>
                                            <%--<asp:TextBox runat="server" ID="adde_state" CssClass="form-control"></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="adde_state" CssClass="form-control" Enabled="False" required></asp:DropDownList>
                                            <div class="help-block">E.g: In process. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Type</label>
                                            <%--<asp:TextBox runat="server" ID="adde_type" CssClass="form-control" required></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="adde_type" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Bug. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Assigned to</label>
                                            <%--<asp:TextBox runat="server" ID="adde_assignedto" CssClass="form-control"></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="adde_assignedto" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Luis. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-md-12 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Summary</label>
                                            <asp:TextBox runat="server" ID="adde_summary" MaxLength="200" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Responsive design is not working on login view. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Date start</label>
                                            <asp:TextBox runat="server" ID="adde_datestart"  CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 10/06/2018. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Date finish</label>
                                            <asp:TextBox runat="server" ID="adde_datefinish" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 10/06/2018. </div>
                                        </div>
                                    </div>
                                </div>

                            </fieldset>
                            <div class="text-center">
                                <asp:Button runat="server" ID="adde_create" CssClass="btn btn-primary" Text="Create task" OnClick="adde_create_Click" />
                            </div>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
