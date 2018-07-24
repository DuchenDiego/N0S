<%@ Page Title="" Language="C#" MasterPageFile="~/MenuVenta.Master" AutoEventWireup="true" CodeBehind="CambiarFotoVen.aspx.cs" Inherits="VentaAlquilerVehiculos.CambiarFotoVen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label runat="server" CssClass="titulo" text="Seleccione la nueva foto de perfil"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:gridview id="grdempl" runat="server" Visible="false"></asp:gridview>
    <table style="width: 100%">
        <tr>
            <td>Nueva Foto</td>
            <td>
                <asp:fileupload id="fileupload1" runat="server"></asp:fileupload>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:button id="btncambiar" runat="server" text="Cambiar Foto" OnClick="btncambiar_Click"  />
            </td>
        </tr>
    </table>
</asp:Content>
