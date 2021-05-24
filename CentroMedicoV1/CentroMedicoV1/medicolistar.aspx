<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medicolistar.aspx.cs" Inherits="CentroMedicoV1.medicolistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Médicos</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Lista de médicos</h2>
                </div>
                <div class="card-body">
                    <p>
                        <a href="MedicoNuevo.aspx">Nuevo</a>
                    </p>
                    <asp:Table 
                        ID="tblMedicos" 
                        runat="server" 
                        CssClass="table table-bordered table-striped">
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Médico</asp:TableCell>
                            <asp:TableCell runat="server">Nombre</asp:TableCell>
                            <asp:TableCell runat="server">Email</asp:TableCell>
                            <asp:TableCell runat="server">Teléfono</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
