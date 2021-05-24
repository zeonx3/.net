<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horaeditar.aspx.cs" Inherits="CentroMedicoV1.horaeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Editar</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2>Editar hora</h2>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Hora" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idhora" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox CssClass="form-control" ID="fecha" runat="server" />
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="fecha" />
                        <asp:RegularExpressionValidator
                            runat="server"
                            ErrorMessage="fecha no valida"
                            ValidationExpression="\d{2}-\d{2}-\d{4}"
                            ControlToValidate="fecha" />
                        
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Hora minuto" />
                        <asp:TextBox CssClass="form-control" ID="horaminuto" runat="server" />
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="horaminuto" />
                        <asp:RegularExpressionValidator
                            runat="server"
                            ErrorMessage="hora no valida"
                            ValidationExpression="\d{2}:\d{2}"
                            ControlToValidate="horaminuto" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:DropDownList CssClass="form-control" ID="idmedico" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idmedico" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Estado" />
                        <asp:DropDownList CssClass="form-control" ID="idestado" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idestado" />
                    </div>

                    <div class="form-group">
                        <asp:Button 
                            CssClass="btn btn-success" 
                            ID="btnGrabar" 
                            runat="server" 
                            Text="Grabar" 
                            OnClick="btnGrabar_Click" />
                    </div>

                    <p>
                        <a href="horalistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
