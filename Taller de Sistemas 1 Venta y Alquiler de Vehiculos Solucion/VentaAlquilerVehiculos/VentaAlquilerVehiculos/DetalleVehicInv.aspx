<%@ Page Title="" Language="C#" MasterPageFile="~/MenuInvitado.Master" AutoEventWireup="true" CodeBehind="DetalleVehicInv.aspx.cs" Inherits="VentaAlquilerVehiculos.DetalleVehicInv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Detalle de Vehiculo Seleccionado"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table style="width: 100%">
        <tr>
            <td>
                Vista de Vehiculo
            </td>
            <td>
                Escanee el codigo QR para ir a la pagina oficial del modelo
            </td>
        </tr>
        <tr>
            <td>
                </br></br>
            <td>
         <tr>
            <td>
                <asp:Image ID="imgfotovehic" runat="server" Height="200px" Width="300px" CssClass="imgperfil" />
            </td>
            <td>
                <asp:Image ID="imgcodigoqr" runat="server" Height="200px" ImageAlign="Middle" />

            </td>
        </tr>
        <tr>
            <td>
                </br></br>
            <td>
        <tr>
            <td>Marca</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Modelo</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Transmision</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Seguridad</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Motor</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Nº Asientos</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Costo de Venta (Usd)</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Costo de Alquiler (Usd) por Semana</td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

    <asp:gridview runat="server" id="grdauxvehicselec" Visible="false" ></asp:gridview>
</asp:Content>
