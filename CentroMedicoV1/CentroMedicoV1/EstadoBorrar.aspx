<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoBorrar.aspx.cs" Inherits="CentroMedicoV1.EstadoBorrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <div class="card-header">
                <h2>Borrar Estado</h2>
            </div>
            <div class="card-body">
                <div class="form-group">
                        <asp:Label runat="server" Text="ID.Estado" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idestado" runat="server" />
                    </div>
                        
                        <div class="form-group">
                        <asp:Label runat="server" Text="Nombre Estado" />
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
                        <a href="EstadoListar.aspx">Volver</a>
                    </p>
            </div>
        </div>
    </form>
</body>
</html>
