<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="ManageElement.aspx.cs" Inherits="lovis.Views.Proyects.Element.ManageElement" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Literal runat="server" ID="pagetitle"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header" data-background-color="purple">
                            <h4 class="title">Manage task</h4>
                            <p class="category">Change whatever you want</p>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h3 runat="server" id="managee_error" class="text-danger text-center">There was an error.</h3>
                            </div>
                        </div>
                        <div class="card-content">
                            <fieldset class="scheduler-border">
                                <legend class="scheduler-border" style="margin-bottom: 5px;">Initial information</legend>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4 col-sm-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Title</label>
                                            <asp:TextBox runat="server" ID="managee_title" CssClass="form-control" required></asp:TextBox>
                                            <div class="help-block">E.g: Responsive not working. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Priority</label>
                                            <%--<asp:TextBox runat="server" ID="adde_priority" CssClass="form-control" required></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="managee_priority" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Critial. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-4 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">State</label>
                                            <%--<asp:TextBox runat="server" ID="adde_state" CssClass="form-control"></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="managee_state" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: In process. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Type</label>
                                            <%--<asp:TextBox runat="server" ID="adde_type" CssClass="form-control" required></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="managee_type" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Bug. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Assigned to</label>
                                            <%--<asp:TextBox runat="server" ID="adde_assignedto" CssClass="form-control"></asp:TextBox>--%>
                                            <asp:DropDownList runat="server" ID="managee_assignedto" CssClass="form-control" required></asp:DropDownList>
                                            <div class="help-block">E.g: Luis. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12 col-md-12 col-sm-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Summary</label>
                                            <asp:TextBox runat="server" ID="managee_summary" TextMode="multiline" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: Responsive design is not working on login view. </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Date start</label>
                                            <asp:TextBox runat="server" ID="managee_datestart" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 10/06/2018. </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="form-group label-floating">
                                            <label class="control-label ">Date finish</label>
                                            <asp:TextBox runat="server" ID="managee_datefinish" CssClass="form-control"></asp:TextBox>
                                            <div class="help-block">E.g: 10/06/2018. </div>
                                        </div>
                                    </div>
                                </div>

                            </fieldset>
                            <div class="text-center">
                                <asp:Button runat="server" ID="managee_update" CssClass="btn btn-primary" Text="Update task" OnClick="managee_update_Click" />
                            </div>
                            <div class="clearfix"></div>

                            <fieldset class="scheduler-border" style="border: 1px solid red !important;">
                                <legend class="scheduler-border" style="margin-bottom: 5px; color: red !important;">Danger zone</legend>
                                <div class="row">
                                    <div class="col-md-8 col-lg-8 col-sm-12">
                                        <div class="form-group label-floating">
                                            <p style="color: red;"><b>Deleted tasks can not be restored since they are wiped out from our database.</b></p>
                                        </div>
                                    </div>
                                    <div class="col-md-2 col-lg-2 col-sm-12">
                                        <div class="form-group label-floating">
                                            <div class="checkbox">
                                                <label>
                                                    <input type="checkbox" runat="server" id="managep_checkbox_delete" required />
                                                    Confirm to delete.
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-2 col-lg-2 col-sm-12">
                                        <div class="form-group label-floating" style="margin-top: 10px !important;">
                                            <asp:Button runat="server" ID="managep_btn_delete" CssClass="btn btn-danger" Text="Delete project" />
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
