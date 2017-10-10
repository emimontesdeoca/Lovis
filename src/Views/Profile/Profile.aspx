<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="lovis.Views.Profile.Profile" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Literal runat="server" ID="pageTitle"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">
    <div class="content" style="padding: 5px 15px !important">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">My Profile</h4>
                            <p class="category">What others see about yourself.</p>
                        </div>
                        <div class="card-content">
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">User</legend>
                                <div class="row">
                                    <div class="col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Company</label>
                                            <asp:TextBox runat="server" ID="user_company" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Email address</label>
                                            <asp:TextBox runat="server" ID="user_username" Type="Email" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Information</legend>
                                <div class="row">
                                    <div class="col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">First Name</label>
                                            <asp:TextBox runat="server" ID="user_name" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last Name</label>
                                            <asp:TextBox runat="server" ID="user_surname" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Address</label>
                                            <asp:TextBox runat="server" ID="user_address" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,30}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">City</label>
                                            <asp:TextBox runat="server" ID="user_city" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Country</label>
                                            <asp:TextBox runat="server" ID="user_country" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Postal Code</label>
                                            <asp:TextBox runat="server" ID="user_cp" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,10$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Social</legend>
                                <div class="row">
                                    <div class="col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Facebook</label>
                                            <asp:TextBox runat="server" ID="user_fb" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Twitter</label>
                                            <asp:TextBox runat="server" ID="user_tw" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Github</label>
                                            <asp:TextBox runat="server" ID="user_gh" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Skype</label>
                                            <asp:TextBox runat="server" ID="user_skype" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">LinkedIn</label>
                                            <asp:TextBox runat="server" ID="user_linkedin" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Google+</label>
                                            <asp:TextBox runat="server" ID="user_googleplus" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,50}$" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">About me</label>
                                            <asp:TextBox runat="server" ID="user_aboutme" TextMode="multiline" ReadOnly="true" Columns="50" Rows="5" MaxLength="100" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
