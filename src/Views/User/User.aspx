<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="lovis.Views.User.User" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    User
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">
    <div class="content">
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
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Company</label>
                                            <asp:TextBox runat="server" ID="user_company" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">Not available yet. </div>

                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Email address</label>
                                            <asp:TextBox runat="server" ID="user_username" Type="Email" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">E.g: shakira@waka.eh.</div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last Modification</label>
                                            <asp:TextBox runat="server" ID="user_lastmodification" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                            <div class="help-block">Last modification to the user.</div>

                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Password</label>
                                            <asp:TextBox runat="server" ID="user_password" Type="Password" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">Minimun length is 8. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Repeat password</label>
                                            <asp:TextBox runat="server" ID="user_repeatpassword" Type="Password" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">Minimun length is 8. </div>
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
                                            <asp:TextBox runat="server" ID="user_name" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Luis. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Last Name</label>
                                            <asp:TextBox runat="server" ID="user_surname" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Sanfiel. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Address</label>
                                            <asp:TextBox runat="server" ID="user_address" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Bader H Al-Khalifa. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">City</label>
                                            <asp:TextBox runat="server" ID="user_city" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Dhahran. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Country</label>
                                            <asp:TextBox runat="server" ID="user_country" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Saudi Arabia. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Postal Code</label>
                                            <asp:TextBox runat="server" ID="user_cp" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 32901. </div>
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
                                            <asp:TextBox runat="server" ID="user_fb" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: https://www.facebook.com/barackobama/. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Twitter</label>
                                            <asp:TextBox runat="server" ID="user_tw" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: https://twitter.com/officiaikanye. </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Github</label>
                                            <asp:TextBox runat="server" ID="user_gh" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: https://github.com/emimontesdeoca. </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">About me</label>
                                            <asp:TextBox runat="server" ID="user_aboutme" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: I am an awesome developer that like lovis a lot!. </div>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                            <div class="row">
                                <div class="col-md-12">
                                    <p class="text-warning text-center">Updating the profile will log out the session.</p>
                                </div>
                            </div>
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
