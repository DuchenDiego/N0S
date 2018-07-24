<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="ModInEmpleado.aspx.cs" Inherits="VentaAlquilerVehiculos.ModInEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Modificacion de Empleado Seleccionado"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" Visible="false" runat="server"></asp:GridView>
    <asp:GridView ID="GridView2" Visible="false" runat="server"></asp:GridView>
     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%=txtFecha.ClientID %>').datepicker(
               {

                   dateFormat: 'dd,mm, yy',
                   minDate: '-50Y',
                   maxDate: '-214M',
                   changeMonth: true,
                   changeYear: true,
                   numberOfMonths: 1,
                   dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                   monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr',
                       'May', 'Jun', 'Jul', 'Ago',
                       'Sep', 'Oct', 'Nov', 'Dic']
               });
         });
        </script>
        <style type="text/css">
            .ui-datepicker {
                font-size: 10pt !important;
            }
        </style>
    <table style="width: 100%">
        <tr>
            <td><strong>CI del Empleado</strong></td>
            <td>
                <asp:textbox id="txtciempl" ReadOnly="true" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtciempl"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Nombre</strong></td>
            <td>
                <asp:textbox id="txtnombreempl" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtnombreempl"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnombreempl" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
        </tr>    
        <tr>
            <td><strong>Apellido Paterno</strong></td>
            <td>
                <asp:textbox id="txtapp" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtapp"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtapp" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Apellido Materno</strong></td>
            <td>
                <asp:textbox id="txtapm" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtapm"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtapm" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
        </tr>
         <tr>
            <td><strong>Nick</strong></td>
            <td>
                <asp:textbox id="txtnick" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtnick"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td><strong>Contraseña</strong></td>
            <td>
                <asp:textbox id="txtpass" TextMode="Password" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Repetir Contraseña</strong></td>
            <td>
                <asp:textbox id="txtconfpass" TextMode="Password" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtconfpass"></asp:RequiredFieldValidator>
                <asp:comparevalidator id="CompareValidator1" runat="server" Display="Dynamic" ControlToValidate="txtpass" ErrorMessage="Password No coincide" ControlToCompare="txtconfpass"></asp:comparevalidator>
            </td>
        </tr>
        <tr>
            <td><strong>Fecha de Nacimiento</strong></td>
            <td>
                <asp:textbox id="txtFecha" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtFecha"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Email(Opcional)</strong></td>
            <td>
                <asp:textbox id="txtemail" runat="server"></asp:textbox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">El campo debe tener formato de correo electronico</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Celular</strong></td>
            <td>
                <asp:textbox id="txtcel" runat="server" MaxLength="7"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtcel"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcel" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Latencia</strong></td>
            <td>
                <asp:textbox id="txtlat" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtlat"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtlat" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td></br></td>
            <td></br></td>
        </tr>
        <tr>
            <td><strong>Sucursal</strong></td>
            <td>
                <asp:dropdownlist ID="ddlsucursals" runat="server" DataSourceID="SqlDataSource1" DataTextField="Direccion" DataValueField="Direccion" OnSelectedIndexChanged="ddlsucursals_SelectedIndexChanged" >
                </asp:dropdownlist>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VentaAlquilerConnectionString %>" SelectCommand="SELECT [Direccion] FROM [Sucursal] WHERE ([Estado] = @Estado)">
                    <SelectParameters>
                        <asp:Parameter Name="Estado" Type="String" DefaultValue="Habilitado" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td></br></td>
            <td></br></td>
        </tr>
        <tr>
            <td>
                <input id="Reset1" type="reset" value="Limpiar" /></td>
            <td>
                <asp:button id="btnmodificar" runat="server" text="Modificar" OnClick="btnmodificar_Click"/>
            </td>
        </tr>
    </table> 
    
</asp:Content>
