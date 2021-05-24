<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservaEditar.aspx.cs" Inherits="CentroMedicoV1.ReservaEditar" %>

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
                    <h2>Editar Reserva</h2>

                </div>
                <div class="card-body">
                     <div class="form-group">
                    <asp:Label runat="server" Text="Fechas disponibles" />
                    <asp:DropDownList 
                                CssClass="form-control"
                                ID="idhora"
                                runat="server"
                                ></asp:DropDownList>
                    <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idhora" />
                        </div>
                    
                    <div class="form-group">
                    <asp:Label runat="server" Text="Nombre Paciente" />
                    <asp:DropDownList 
                                CssClass="form-control"
                                ID="idpaciente"
                                runat="server"
                                ></asp:DropDownList>
                    <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idpaciente" />
                        </div>
                    <div class="form-group">
                    <asp:Label runat="server" Text="Especialidad" />
                    <asp:DropDownList 
                        AutoPostBack ="true"
                                CssClass="form-control"
                                ID="idespecialidad"
                                runat="server" OnSelectedIndexChanged="idespecialidad_SelectedIndexChanged" 
                                ></asp:DropDownList>
                    <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idespecialidad" />
                        </div>
                    <div class="form-group">
                    <asp:Label runat="server" Text="Nombre Medico" />
                    <asp:DropDownList 
                                CssClass="form-control"
                                ID="idmedico"
                                runat="server" 
                                ></asp:DropDownList>
                    <asp:RequiredFieldValidator
                            runat="server"
                            ErrorMessage="Requerido"
                            ControlToValidate="idmedico" />
                        </div>
                     <div class="form-group">
                        <asp:Button 
                            CssClass="btn btn-info" 
                            ID="btnGrabar" 
                            runat="server" 
                            Text="Grabar" 
                            OnClick="btnGrabar_Click" 
                             />
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
