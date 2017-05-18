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
                                <asp:Button runat="server" ID="proyect_newtask" OnClick="proyect_newtask_Click" CssClass="btn btn-primary btn-ms btn-manage-proyect btn-responsive" Text="New task" />
                                <asp:Button runat="server" ID="proyect_manageproyect" OnClick="proyect_manageproyect_Click" CssClass="btn btn-warning btn-ms btn-manage-proyect btn-responsive" Text="Manage proyect" />
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>

            <%-- <div class="row">
                <div class="col-md-12">
                    <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingOne">
                                <h4 class="panel-title">
                                    <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">Examenes</a>
                                    <button type="button" class="btn btn-primary" style="float: right; padding: 6px 12px; margin: -3px 1px;">Nuevo</button>
                                </h4>
                            </div>
                            <div id="collapseOne" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingOne">
                                <div class="panel-body">
                                    <div class="card-content table-responsive">
                                        <table class="table">
                                            <thead class="text-primary">
                                                <th>Titulo</th>
                                                <th>Estado</th>
                                                <th>Fecha creacion</th>
                                                <th>Fecha finalizacion</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Editar</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Borrar</th>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <!-- <button type="button" class="btn btn-primary" style=" padding: 6px 12px">Editar</button> -->
                                                        <button type="button" rel="tooltip" title="Edit Task" class="btn btn-primary btn-simple btn-xs">
                                                            <i class="material-icons">edit</i>
                                                        </button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <!-- <button type="button" class="btn btn-danger" style=" padding: 6px 12px">Borrar</button> -->
                                                        <button type="button" rel="tooltip" title="Remove" class="btn btn-danger btn-simple btn-xs">
                                                            <i class="material-icons">close</i>
                                                        </button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">ASP.net</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingTwo">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">Tareas</a>
                                    <button type="button" class="btn btn-primary" style="float: right; padding: 6px 12px; margin: -3px 1px;">Nuevo</button>
                                </h4>
                            </div>
                            <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                <div class="panel-body">
                                    <div class="card-content table-responsive">
                                        <table class="table">
                                            <thead class="text-primary">
                                                <th>Titulo</th>
                                                <th>Estado</th>
                                                <th>Fecha creacion</th>
                                                <th>Fecha finalizacion</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Editar</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Borrar</th>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">ASP.net</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingThree">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">Actividades</a>
                                    <button type="button" class="btn btn-primary" style="float: right; padding: 6px 12px; margin: -3px 1px;">Nuevo</button>
                                </h4>
                            </div>
                            <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                                <div class="panel-body">
                                    <div class="card-content table-responsive">
                                        <table class="table">
                                            <thead class="text-primary">
                                                <th>Titulo</th>
                                                <th>Estado</th>
                                                <th>Fecha creacion</th>
                                                <th>Fecha finalizacion</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Editar</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Borrar</th>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">ASP.net</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading" role="tab" id="headingFour">
                                <h4 class="panel-title">
                                    <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseFour" aria-expanded="false" aria-controls="collapseFour">Prácticas</a>
                                    <button type="button" class="btn btn-primary" style="float: right; padding: 6px 12px; margin: -3px 1px;">Nuevo</button>
                                </h4>
                            </div>
                            <div id="collapseFour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
                                <div class="panel-body">
                                    <div class="card-content table-responsive">
                                        <table class="table">
                                            <thead class="text-primary">
                                                <th>Titulo</th>
                                                <th>Estado</th>
                                                <th>Fecha creacion</th>
                                                <th>Fecha finalizacion</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Editar</th>
                                                <th style="text-overflow: ellipsis; width: 150px;">Borrar</th>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">ASP.net</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">27/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 0px 10px;">Razor</td>
                                                    <td style="padding: 0px 10px;">Por hacer</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td class="text-primary" style="padding: 0px 10px;">26/04/2015</td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-primary" style="padding: 6px 12px">Editar</button>
                                                    </td>
                                                    <td style="padding: 0px 10px;">
                                                        <button type="button" class="btn btn-danger" style="padding: 6px 12px">Borrar</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>--%>
        </div>
    </div>

</asp:Content>
