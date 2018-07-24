<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="ModInSucursal.aspx.cs" Inherits="VentaAlquilerVehiculos.ModInSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label runat="server" CssClass="titulo" text="Modificacion de Sucursal Seleccionada"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:gridview ID="gvseleccion" runat="server" Visible="false"></asp:gridview>
    <asp:label runat="server" CssClass="subtitulos"  text="Ingrese los campos que desea modificar"></asp:label>
    <table style="width: 100%">
        <tr>
            <td><strong>Direccion</strong></td>
            <td>
                <asp:textbox ID="txtdireccion"  runat="server"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtdireccion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Zona</strong></td>
            <td>
                 <asp:textbox ID="txtzona"  runat="server"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtzona"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtzona" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Telefono</strong></td>
            <td>
                <asp:textbox ID="txttelefono"  runat="server"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txttelefono"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txttelefono" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Cantidad Maxima de Vehiculos</strong></td>
            <td>
                 <asp:textbox ID="txtcantidadmaxv"  runat="server"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtcantidadmaxv"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcantidadmaxv" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:button id="btnmodificarsuc" runat="server" text="Modificar" OnClick="btnmodificarsuc_Click" OnClientClick="return confirm('Esta seguro de modificar los Datos de la Sucursal');" />
            </td>
        </tr>
    </table>
</asp:Content>
