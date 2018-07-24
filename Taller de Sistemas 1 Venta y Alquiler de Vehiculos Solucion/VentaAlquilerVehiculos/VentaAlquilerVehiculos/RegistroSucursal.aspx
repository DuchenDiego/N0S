<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="RegistroSucursal.aspx.cs" Inherits="VentaAlquilerVehiculos.RegistroSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Registro de Sucursal"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <table style="width: 100%">
        <tr>
            <td><strong>Direccion</strong></td>
            <td>
                <asp:textbox id="txtdireccion" runat="server"></asp:textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtdireccion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Zona</strong></td>
            <td>
                <asp:textbox id="txtzona" runat="server"></asp:textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtzona"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtzona" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Telefono</strong></td>
            <td>
                <asp:textbox id="txttelf" runat="server" MaxLength="7"></asp:textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txttelf"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txttelf" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Cantidad Maxima de Vehiculos</strong></td>
            <td>
                <asp:textbox id="txtcantmax" runat="server"></asp:textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtcantmax"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcantmax" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:button id="btnregistrosuc" runat="server" text="Registrar" OnClick="btnregistrosuc_Click" />
            </td>
        </tr>
    </table>
    
</asp:Content>
