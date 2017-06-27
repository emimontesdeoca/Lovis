<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="lovis.Views.Profile.Profile" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    My profile
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">
    <div class="content" style="padding: 5px 15px !important">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">My Profile</h4>
                            <p class="category">Where you show </p>
                        </div>
                        <div class="card-content">
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">User</legend>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Company</label>
                                            <asp:TextBox runat="server" ID="user_company" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
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
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">First Name</label>
                                            <asp:TextBox runat="server" ID="user_name" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last Name</label>
                                            <asp:TextBox runat="server" ID="user_surname" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Address</label>
                                            <asp:TextBox runat="server" ID="user_address" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">City</label>
                                            <asp:TextBox runat="server" ID="user_city" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Country</label>
                                            <asp:TextBox runat="server" ID="user_country" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Postal Code</label>
                                            <asp:TextBox runat="server" ID="user_cp" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Social</legend>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Facebook</label>
                                            <asp:TextBox runat="server" ID="user_fb" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Twitter</label>
                                            <asp:TextBox runat="server" ID="user_tw" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Github</label>
                                            <asp:TextBox runat="server" ID="user_gh" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Skype</label>
                                            <asp:TextBox runat="server" ID="user_skype" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">LinkedIn</label>
                                            <asp:TextBox runat="server" ID="user_linkedin" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Google+</label>
                                            <asp:TextBox runat="server" ID="user_googleplus" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">About me</label>
                                            <asp:TextBox runat="server" ID="user_aboutme" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
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
