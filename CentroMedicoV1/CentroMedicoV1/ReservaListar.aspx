<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservaListar.aspx.cs" Inherits="CentroMedicoV1.ReservaListar" %>

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
                    <h2>Listar Reserva</h2>
                </div>

                <div class="card-body">
                    <p>
                        <a href="NuevoReserva.aspx">Nueva Reserva</a>
                    </p>
                      
                    
                        
                     <div class="row">
                         <div class="col-md-3">
                             <asp:Label runat="server" Text="Fecha" />
                         </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" Text="Especialidad" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" Text="Médico" />
                        </div>

                    </div>
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList 
                                CssClass="form-control"
                                ID="idhora"
                                runat="server"
                                ></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList
                                CssClass="form-control"
                                ID="idespecialidad"
                                runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList
                                CssClass="form-control"
                                ID="idmedico"
                                runat="server">
                            </asp:DropDownList>
                        </div>

                        <div class="col-md-2">
                            <asp:Button 
                                CssClass="btn btn-warning"
                                ID="btnBuscar" 
                                runat="server" 
                                Text="Buscar" 
                                OnClick="btnBuscar_Click" />
                        </div>

                    <asp:Table id="tblreserva" runat="server" CssClass="table table-bordered table-striped">
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Reserva</asp:TableCell>
                            <asp:TableCell runat="server">Fecha</asp:TableCell>
                            <asp:TableCell runat="server">Hora Minuto</asp:TableCell>
                            <asp:TableCell runat="server">Medico</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                            <asp:TableCell runat="server">Paciente</asp:TableCell>

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
