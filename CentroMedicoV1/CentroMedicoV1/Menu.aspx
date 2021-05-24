<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CentroMedicoV1.Menu" %>

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
                <h2>Menu</h2>
            </div>
            <div class="card-body">
                 <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnespecialidad"
                            runat="server"
                            Text="Lista Especialidades"
                            OnClick="btnespecialidad_Click" />
                    </div>
                <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnestado"
                            runat="server"
                            Text="Lista Estados"
                            OnClick="btnestado_Click" />
                    </div>
                <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnmedico"
                            runat="server"
                            Text="Lista Medicos"
                            OnClick="btnmedico_Click" />
                    </div>
                <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnhora"
                            runat="server"
                            Text="Lista de Horas"
                            OnClick="btnhora_Click" />
                    </div>
                <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-primary"
                            ID="btnreserva"
                            runat="server"
                            Text="Lista de Reservas"
                            OnClick="btnreserva_Click" />
                    </div>
            </div>
        </div>
            
    </form>
</body>
</html>
