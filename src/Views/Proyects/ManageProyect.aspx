<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="ManageProyect.aspx.cs" Inherits="lovis.Views.Proyects.ManageProyect" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Manage proyect
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-6 col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Edit proyect</h4>
                            <p class="category">Change the information about the proyect</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-lg-12 col-md-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Title</label>
                                        <asp:TextBox runat="server" ID="mng_title" CssClass="form-control"></asp:TextBox>
                                        <div class="help-block">Minimum of 6 characters</div>
                                    </div>
                                </div>
                                <%--<div class="col-lg-6 col-md-6">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Users</label>
                                        <asp:DropDownList runat="server" ID="mng_userslist" CssClass="form-control"></asp:DropDownList>
                                        <%--<asp:TextBox runat="server" ID="TextBox1" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>--%>
                            </div>
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="form-group label-floating">
                                        <label class="control-label">Sumary</label>
                                        <asp:TextBox runat="server" ID="mng_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                        <div class="help-block">Maximun of 200 characters</div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="text-center">
                                    <asp:Button runat="server" ID="mng_update" CssClass="btn btn-primary " Text="Update proyect" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-8 col-md-8 col-sm-10 ">
                                    <div class="form-group label-floating">
                                        <div class="checkbox">
                                            <label>
                                                <input type="checkbox" runat="server" id="Checkbox1" required />
                                                Confirm to delete the proyect, this can't be restored.
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-4 col-sm-2 text-center">
                                    <div class="form-group label-floating" style="margin-top: 15px !important">
                                        <asp:Button runat="server" ID="Button1" CssClass="btn btn-danger btn-sm" Text="Remove proyect" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="col-lg-6 col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Manage users</h4>
                            <p class="category">Add or remove users from your proyect</p>
                        </div>
                        <div class="card-content">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card-content table-responsive">
                                        <table class="table">
                                            <thead class="text-primary">
                                                <th>Name</th>
                                                <th>Surname</th>
                                                <th>Email</th>
                                                <th>Role</th>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Emiliano</td>
                                                    <td>Montesdeoca</td>
                                                    <td>emontesdeoc@gmail.com</td>
                                                    <td>Admin</td>
                                                </tr>
                                                <tr>
                                                    <td>Luis</td>
                                                    <td>Sanfiel</td>
                                                    <td>sanfielluis@gmail.com</td>
                                                    <td>Manager</td>
                                                </tr>

                                            </tbody>
                                        </table>

                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="card-content">
                                    <div class="col-lg-8 col-md-8 col-sm-10">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Delete user</label>
                                            <asp:DropDownList runat="server" ID="DropDownList1" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-2 text-center">
                                        <div class="form-group label-floating">
                                            <asp:Button runat="server" ID="Button4" CssClass="btn btn-primary btn-sm" Text="Remove user" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="card-content">
                                    <div class="col-md-4 col-sm-5">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Edit user role</label>
                                            <asp:DropDownList runat="server" ID="DropDownList2" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-5 text-center">
                                        <div class="form-group label-floating">
                                            <label class="control-label">New role</label>
                                            <asp:DropDownList runat="server" ID="DropDownList3" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-2 text-center">
                                        <div class="form-group label-floating">
                                            <asp:Button runat="server" ID="Button3" CssClass="btn btn-primary btn-sm" Text="Edit user" />
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>


                        <div class="text-center">
                            <asp:Button runat="server" ID="Button2" CssClass="btn btn-primary" Text="Update proyect" />
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
