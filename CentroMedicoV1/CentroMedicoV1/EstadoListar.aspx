<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoListar.aspx.cs" Inherits="CentroMedicoV1.EstadoListar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Estado</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Lista de estados</h2>
                </div>
                <div class="card-body">
                    <p>
                        <a href="EstadoNuevo.aspx">Nuevo</a>
                    </p>
                    <asp:Table ID="tblestado" runat="server"  CssClass="table table-bordered table-striped">
                         <asp:TableRow runat="server" TableSection="TableHeader">
                        <asp:TableCell runat="server">Id.Estado</asp:TableCell>
                            <asp:TableCell runat="server">Descripcion</asp:TableCell>
                            
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Borrar</asp:TableCell>
                        </asp:TableRow>
                             </asp:Table>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
