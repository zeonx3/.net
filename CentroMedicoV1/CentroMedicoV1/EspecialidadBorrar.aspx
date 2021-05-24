<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EspecialidadBorrar.aspx.cs" Inherits="CentroMedicoV1.EspecialidadBorrar" %>

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
                    <h2>Borrar Especialidad</h2>
                    <div class="card-body">

                        <div class="form-group">
                        <asp:Label runat="server" Text="ID.Especialidad" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idespecialidad" runat="server" />
                    </div>
                        
                        <div class="form-group">
                        <asp:Label runat="server" Text="Nombre Especialidad" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="descripcion" runat="server" />
                       


                    </div>
                        <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-warning"
                            ID="btnGrabar"
                            runat="server"
                            Text="Borrar"
                            OnClick="btnGrabar_Click" />
                    </div>
                        <p>
                        <a href="EspecialidadListar.aspx">Volver</a>
                    </p>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
