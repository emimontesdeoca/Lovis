<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="lovis.Views.User.User" %>

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
                            <h4 class="title">Edit Profile</h4>
                            <p class="category">Complete your profile</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-md-12">
                                    <h3 runat="server" id="user_error" class="text-danger text-center">There was an error.</h3>
                                </div>
                            </div>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">User</legend>
                                <div class="row">
                                    <div class="col-lg-3 col-md-6 col-sm-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Company</label>
                                            <asp:TextBox runat="server" ID="user_company" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">Not available yet. </div>

                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Email address</label>
                                            <asp:TextBox runat="server" ID="user_username" Type="Email" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">E.g: shakira@waka.eh.</div>
                                        </div>
                                    </div>
                                    <div class="col-lg-2 col-md-6 col-sm-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Registration date</label>
                                            <asp:TextBox runat="server" ID="user_registerdate" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">Last modification to the user.</div>
                                        </div>
                                    </div>
                                    <div class="col-lg-2 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last modification</label>
                                            <asp:TextBox runat="server" ID="user_lastmodification" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">When user registered.</div>
                                        </div>
                                    </div>
                                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                                        <div class="form-group label-floating">
                                            <div class="checkbox">
                                                <label>
                                                    <input type="checkbox" runat="server" id="user_public" />
                                                    Public profile.
                                                </label>
                                            </div>
                                            <div class="help-block">If users can see your profile.</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Current password</label>
                                            <asp:TextBox runat="server" ID="user_currentpassword" Type="Password" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">Minimun length is 8. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Repeat new password</label>
                                            <asp:TextBox runat="server" ID="user_password" Type="Password" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">Minimun length is 8. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">New password</label>
                                            <asp:TextBox runat="server" ID="user_repeatpassword" Type="Password" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">Minimun length is 8. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-md-12 col-sm-12 col-xs-12">
                                        <div class="form-group label-floating text-center">
                                            <asp:Button runat="server" ID="user_updatepasswordbtn" CssClass="btn btn-primary btn-xs" Text="Update password" OnClick="user_updatepasswordbtn_Click" />
                                        </div>
                                        <div class="help-block text-center">Password change will sign out automatically. </div>

                                    </div>
                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Information</legend>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">First Name</label>
                                            <asp:TextBox runat="server" ID="user_name" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Luis. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last Name</label>
                                            <asp:TextBox runat="server" ID="user_surname" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Sanfiel. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-md-12  col-sm-12 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Address</label>
                                            <asp:TextBox runat="server" ID="user_address" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,30}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Bader H Al-Khalifa. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">City</label>
                                            <asp:TextBox runat="server" ID="user_city" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Dhahran. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Country</label>
                                            <asp:TextBox runat="server" ID="user_country" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Saudi Arabia. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Postal Code</label>
                                            <asp:TextBox runat="server" ID="user_cp" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,10}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 32901. </div>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Social</legend>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Facebook</label>
                                            <asp:TextBox runat="server" ID="user_fb" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: barackobama. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Twitter</label>
                                            <asp:TextBox runat="server" ID="user_tw" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: officiaikanye. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Github</label>
                                            <asp:TextBox runat="server" ID="user_gh" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: emimontesdeoca. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Skype</label>
                                            <asp:TextBox runat="server" ID="user_skype" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: peterlaanguila. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">LinkedIn</label>
                                            <asp:TextBox runat="server" ID="user_linkedin" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: ronaldo. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Google+</label>
                                            <asp:TextBox runat="server" ID="user_googleplus" pattern="^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 12378341313103488825. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">About me</label>
                                            <asp:TextBox runat="server" ID="user_aboutme" TextMode="multiline" Columns="50" MaxLength="150" Rows="5" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: I am an awesome developer that like lovis a lot!. </div>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <%-- <div class="row">
                                <div class="col-md-12">
                                    <p class="text-warning text-center">Updating the password will log out the session.</p>
                                </div>
                            </div>--%>
                            <div class="text-center">
                                <asp:Button runat="server" ID="user_update" CssClass="btn btn-primary" Text="Update profile" OnClick="user_update_Click" />
                            </div>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
