<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="ManageProyect.aspx.cs" Inherits="lovis.Views.Proyects.ManageProyect" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Literal runat="server" ID="pagetitle"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Manage </h4>
                            <p class="category">Change the project's information or settings.</p>
                        </div>
                        <div class="card-content">
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Initial information</legend>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Title</label>
                                            <asp:TextBox runat="server" ID="addp_title" CssClass="form-control" required></asp:TextBox>
                                            <div class="help-block">E.g: Facebo- oh wait. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Owner</label>
                                            <asp:TextBox runat="server" ID="addp_owner" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">Proyect owner. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 col-lg-12 col-sm-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Summary</label>
                                            <asp:TextBox runat="server" ID="addp_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: This is an application that connects a lot of people and will make me rich. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4 col-lg-4 col-sm-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Project website</label>
                                            <asp:TextBox runat="server" ID="addp_webiste" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: https://www.myproyectwebpage.com. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-lg-4 col-sm-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Repository website</label>
                                            <asp:TextBox runat="server" ID="addp_repository" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: https://github.com/emimontesdeoca/lovis. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-lg-4 col-sm-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Support email</label>
                                            <asp:TextBox runat="server" ID="addp_support" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: support@proyect.com. </div>
                                        </div>
                                    </div>

                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Collaborators</legend>
                                <div class="row">
                                    <div class="col-md-12 col-lg-12 col-sm-12">
                                        <div class="form-group label-floating">
                                            <p>Collaborators are allowed to create, edit and remove tickets from the proyect, but not allowed to edit or remove the proyect. Search then by their username (email) separated by comma (,).</p>
                                        </div>
                                    </div>
                                    <div class="col-md-12 col-lg-12 col-sm-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Invite people</label>
                                            <asp:TextBox runat="server" ID="addp_invitepeople" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">For example: brian@gmail.com, strongsqueleton@outlook.com, creeper@mojang.net..</div>
                                        </div>
                                    </div>
                                    <div class="col-md-12 col-lg-12 col-sm-12">
                                        <div class="form-group label-floating">
                                            <p>Invited users will receive an email with the information about this proyect and a confirmation link where they can join the proyect.</p>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <div class="text-center">
                                <asp:Button runat="server" ID="addp_create" CssClass="btn btn-primary" Text="Create proyect" />
                            </div>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
