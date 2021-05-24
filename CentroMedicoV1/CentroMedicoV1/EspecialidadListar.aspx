<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EspecialidadListar.aspx.cs" Inherits="CentroMedicoV1.EspecialidadListar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Especialidades</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Lista de Especialidades</h2>
                    <div class="card-body">
                        <p>
                        <a href="EspecialidadNuevo.aspx">Nuevo</a>
                    </p>
                        <asp:Table ID="tblEspecialidad" runat="server"
                            CssClass="table table-bordered table-striped">
                            <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Especialidad</asp:TableCell>
                            <asp:TableCell runat="server">Descripcion</asp:TableCell>
                            
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Borrar</asp:TableCell>
                        </asp:TableRow>
                             </asp:Table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
