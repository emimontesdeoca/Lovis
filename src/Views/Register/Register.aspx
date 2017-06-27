<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lovis.Views.Register.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <link rel="icon" href="../Shared/Assets/icon/favicon.ico" />

    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>Registration - Lovis</title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />
    <!-- Bootstrap core CSS     -->
    <link href="../Shared/Assets/css/bootstrap.min.css" rel="stylesheet" />
    <!--  Material Dashboard CSS    -->
    <link href="../Shared/Assets/css/material-dashboard.css" rel="stylesheet" />
    <!--  Lovis CSS  -->
    <link href="../Shared/Assets/css/style.css" rel="stylesheet" />
    <!--     Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300|Material+Icons' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <div class="container-fluid " style="min-width: 550px; max-width: 550px; height: 100%; position: absolute; top: 50%; bottom: 0; left: 0; right: 0; margin: auto;">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-header" data-background-color="purple">
                                <h2 class="title text-center">Lovis</h2>
                                <p class="category text-center">Keep track of everything</p>
                            </div>
                            <div class="card-content">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <label class="control-label">Email address</label>
                                            <asp:TextBox ID="reg_email" runat="server" TextMode="Email" CssClass="form-control" required></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label for="reg_password" class="control-label">Password</label>
                                            <asp:TextBox ID="reg_password" runat="server" TextMode="Password" data-minlength="6" CssClass="form-control" required pattern="^[_A-z0-9]{1,}$"></asp:TextBox>
                                            <div class="help-block">Minimum of 6 characters</div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label for="reg_repeatpassword" class="control-label">Repeat password</label>
                                            <asp:TextBox ID="reg_repeatpassword" runat="server" TextMode="Password" data-minlength="6" data-match="#reg_password" data-match-error="Whoops, these don't match" CssClass="form-control" required pattern="^[_A-z0-9]{1,}$"></asp:TextBox>
                                            <div class="help-block with-errors"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label for="reg_name" class="control-label">Name</label>
                                            <asp:TextBox ID="reg_name" runat="server" CssClass="form-control" data-minlength="3" data-maxlength="20" required pattern="^[_A-z0-9]{1,}$"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group label-floating">
                                            <label for="reg_surname" class="control-label">Surname</label>
                                            <asp:TextBox ID="reg_surname" runat="server" CssClass="form-control" data-minlength="3" data-maxlength="20" required pattern="^[_A-z0-9]{1,}$"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group label-floating">
                                            <div class="checkbox">
                                                <label>
                                                    <input type="checkbox" runat="server" id="reg_checkbox" required />
                                                    I agree to the <a href="#">Terms and Conditions</a>.
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <p class="text-center text-warning">An email will be sent with a link to confirm the registration.</p>
                                    </div>
                                </div>
                                <div class="text-center">
                                    <asp:Button runat="server" ID="reg_register" OnClick="reg_register_Click" CssClass="btn btn-primary" Text="Register" />
                                </div>
                                <div class="clearfix"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!--   Core JS Files   -->
    <script src="../Shared/Assets/js/jquery-3.1.0.min.js" type="text/javascript"></script>
    <script src="../Shared/Assets/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../Shared/Assets/js/material.min.js" type="text/javascript"></script>
    <!-- Material Dashboard javascript methods -->
    <script src="../Shared/Assets/js/material-dashboard.js"></script>
    <!-- Material Dashboard DEMO methods, don't include it in your project! -->
</body>
</html>
