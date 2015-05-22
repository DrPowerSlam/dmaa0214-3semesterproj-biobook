<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClientWebApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            padding-top: 40px;
            padding-bottom: 40px;
            background-color: #eee;
        }

        .form-signin {
            max-width: 330px;
            padding: 15px;
            margin: 0 auto;
        }

            .form-signin .form-signin-heading,
            .form-signin .checkbox {
                margin-bottom: 10px;
            }

            .form-signin .checkbox {
                font-weight: normal;
            }

            .form-signin .form-control {
                position: relative;
                height: auto;
                -webkit-box-sizing: border-box;
                -moz-box-sizing: border-box;
                box-sizing: border-box;
                padding: 10px;
                font-size: 16px;
            }

                .form-signin .form-control:focus {
                    z-index: 2;
                }

            .form-signin input[type="email"] {
                margin-bottom: -1px;
                border-bottom-right-radius: 0;
                border-bottom-left-radius: 0;
            }

            .form-signin input[type="password"] {
                margin-bottom: 10px;
                border-top-left-radius: 0;
                border-top-right-radius: 0;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">

                <div class="form-signin">

                    <h2 class="form-signin-heading">Log ind</h2>


                    <input name="txtMail" type="text" id="txtMail" class="form-control" placeholder="E-mail adresse" />

                    <p>
                    </p>

                    <input name="txtPassword" type="text" id="txtPassword" class="form-control" placeholder="Adgangskode" />

                    <p>
                    </p>

                    <asp:Button ID="btnLogin" runat="server" Text ="Log ind" CssClass="btn btn-lg btn-primary btn-block" OnClick="btnLogin_Click" />
                    

                    <br />
                    <a href="#">Glemt adgangskode?</a>
                    <br />


                </div>



            </div>
            <!-- /container -->

        </div>
    </form>
</body>
</html>
