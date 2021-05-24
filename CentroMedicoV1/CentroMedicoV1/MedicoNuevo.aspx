<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicoNuevo.aspx.cs" Inherits="CentroMedicoV1.MedicoNuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Nuevo médico</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Nuevo médico</h2>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Médico" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idmedico" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Nombres" />
                        <asp:TextBox CssClass="form-control" ID="nombres" runat="server" />
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Nombres es requerido"
                            ControlToValidate="nombres" />

                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Apellidos" />
                        <asp:TextBox CssClass="form-control" ID="apellidos" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Email" />
                        <asp:TextBox CssClass="form-control" ID="email" runat="server" TextMode="Email" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Teléfono" />
                        <asp:TextBox CssClass="form-control" ID="telefono" runat="server" TextMode="Number" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:DropDownList CssClass="form-control" ID="idespecialidad" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Especialidad es requerido"
                            ControlToValidate="idespecialidad" />
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
