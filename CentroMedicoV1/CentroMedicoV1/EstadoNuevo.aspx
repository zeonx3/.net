﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoNuevo.aspx.cs" Inherits="CentroMedicoV1.EstadoNuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Nuevo Estado</h2>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Nombre Estado" />
                        <asp:TextBox CssClass="form-control" ID="descripcion" runat="server" />
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="nombre requerido"
                            ControlToValidate="descripcion" />  
                    </div>
                                            <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-info"
                            ID="btnGrabar"
                            runat="server"
                            Text="Grabar"
                            OnClick="btnGrabar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
