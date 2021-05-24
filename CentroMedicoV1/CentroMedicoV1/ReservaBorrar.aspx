<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservaBorrar.aspx.cs" Inherits="CentroMedicoV1.WebForm1" %>

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
                    <h2>Borrar Reserva</h2>

                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="ID.Reserva" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idreserva" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Paciente" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idpaciente" runat="server" />
                    </div>
                     <div class="form-group">
                         <asp:Label runat="server" Text="Medico"/>
                         <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idmedico" runat="server" />
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha"/>
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idhora" runat="server" />
                        
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
                        <a href="ReservaListar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
