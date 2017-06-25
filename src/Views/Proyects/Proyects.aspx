<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Master.Master" AutoEventWireup="true" CodeBehind="Proyects.aspx.cs" Inherits="lovis.Views.Proyects.Proyects" %>

<%@ MasterType VirtualPath="~/Views/Shared/Master.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Literal runat="server" ID="pagetitle"></asp:Literal>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ViewContainer" runat="server">
    <div class="content" style="margin-top: 50px;">
        <div class="container-fluid">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <fieldset class="scheduler-border">
                            <legend class="scheduler-border" style="margin-bottom: 5px;">Summary</legend>
                            <p runat="server" id="proyect_summary"></p>
                        </fieldset>
                    </div>
                    <div class="col-lg-3 col-md-4 col-sm-4">
                        <fieldset class="scheduler-border">
                            <legend class="scheduler-border" style="margin-bottom: 5px;">Information</legend>
                            <p>
                                Website:
                                <asp:HyperLink runat="server" ID="proyect_website"></asp:HyperLink>
                            </p>
                            <p>
                                Repository:
                                <asp:HyperLink runat="server" ID="proyect_repository"></asp:HyperLink>
                            </p>
                            <p>
                                Support:
                                <asp:HyperLink runat="server" ID="proyect_support"></asp:HyperLink>
                            </p>
                        </fieldset>
                    </div>
                    <div class="col-lg-3 col-md-5 col-sm-5">
                        <fieldset class="scheduler-border">
                            <legend class="scheduler-border" style="margin-bottom: 5px;">Collaborators</legend>
                            <p runat="server" id="proyect_people"></p>
                        </fieldset>
                    </div>
                    <div class="col-lg-2 col-md-3 col-sm-3 text-center">
                        <fieldset class="scheduler-border">
                            <legend class="scheduler-border" style="margin-bottom: 5px;">Management</legend>
                            <div class="btn-group-vertical ">
                                <asp:HyperLink runat="server" ID="proyect_newtask" CssClass="btn btn-primary btn-ms btn-manage-proyect btn-responsive" Text="New task" />
                                <asp:HyperLink runat="server" ID="proyect_manage" CssClass="btn btn-warning btn-ms btn-manage-proyect btn-responsive" Text="Manage proyect" />
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingOne">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                    <h4 class="panel-title">Bugs
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseOne" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingOne">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtBug"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divBug">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="bugPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingTwo">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="true" aria-controls="collapseTwo">
                                    <h4 class="panel-title">Defect
                                    </h4>
                                </a>
                            </div>

                            <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtDefect"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divDefect">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="defectPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingThree">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="true" aria-controls="collapseThree">
                                    <h4 class="panel-title">Patches
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtPatches"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divPatches">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="patchesPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingFour">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseFour" aria-expanded="true" aria-controls="collapseFour">
                                    <h4 class="panel-title">Changes 
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseFour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtChanges"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divChanges">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="changesPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingFive">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseFive" aria-expanded="true" aria-controls="collapseFive">
                                    <h4 class="panel-title">Feature 
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseFive" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFive">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtFeature"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divFeatures">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="featurePanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingSix">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseSix" aria-expanded="true" aria-controls="collapseSix">
                                    <h4 class="panel-title">Support 
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseSix" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingSix">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtSupport"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divSupport">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="supportPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingSeven">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseSeven" aria-expanded="true" aria-controls="collapseSeven">
                                    <h4 class="panel-title">Review 
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseSeven" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingSeven">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtReview"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divReview">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="reviewPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingEigth">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseEigth" aria-expanded="true" aria-controls="collapseEigth">
                                    <h4 class="panel-title">Documentation
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseEigth" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingEigth">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtDocumentation"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divDocumentation">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="documentationPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingNine">
                                <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseNine" aria-expanded="true" aria-controls="collapseNine">
                                    <h4 class="panel-title">Closed 
                                    </h4>
                                </a>
                            </div>
                            <div id="collapseNine" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingNine">
                                <div class="panel-body">
                                    <asp:Literal runat="server" ID="txtClosed"></asp:Literal>
                                    <div class="card-content table-responsive" runat="server" id="divClosed">
                                        <table class="table" style="margin-bottom: 0px !important">
                                            <thead class="text-primary">
                                                <th>Title</th>
                                                <th>Type</th>
                                                <th>State</th>
                                                <th>Priority</th>
                                                <th>Assigned to</th>
                                                <th>Creation date</th>
                                                <th>Start date</th>
                                                <th>Finish date</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Manage</th>
                                            </thead>
                                            <tbody>
                                                <asp:Literal runat="server" ID="closedPanel"></asp:Literal>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
