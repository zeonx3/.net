<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CentroMedicoV1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Centro médico</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/base.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Acceso usuario</h2>
                </div>
                <div class="card-body divLogin">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Usuario:" />
                        <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Clave:" />
                        <asp:TextBox CssClass="form-control" ID="txtClave" runat="server" TextMode="Password" />
                    </div>
                    <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnLogin"
                            runat="server"
                            Text="Enviar"
                            OnClick="btnLogin_Click" />
                    </div>

                    <asp:Label
                        ID="lblMsg"
                        runat="server"
                        CssClass="alert alert-danger"
                        Text=""
                        Visible="false" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
