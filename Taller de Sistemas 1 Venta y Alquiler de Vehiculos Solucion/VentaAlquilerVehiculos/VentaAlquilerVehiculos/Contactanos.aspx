<%@ Page Title="" Language="C#" MasterPageFile="~/MenuInvitado.Master" AutoEventWireup="true" CodeBehind="Contactanos.aspx.cs" Inherits="VentaAlquilerVehiculos.Contactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Contacta con nosotros"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table border style="width: 100%">
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/twiter.png" />
            </td>
            <td>@VentaAlquilerN2O</td>
            <td>
                <asp:Image ID="Image2" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/loc.jpg" />
            </td>
            <td>Rep Domenicana #2278</td>
        </tr>
        <tr> 
            <td>
                <asp:Image ID="Image3" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/fb.png" />
            </td>
            <td>facebook.com/VentaAlquilerN2O_Oficial</td>
            <td>
                <asp:Image ID="Image4" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/tel.png" />
            </td>
            <td>2228679-71592347</td>
        </tr>
         <tr> 
            <td>
                <asp:Image ID="Image5" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/correo.png" />
            </td>
            <td>plisinauditore@gmail.com</td>
        </tr>
    </table>
    <asp:Button ID="btnmaps" runat="server" Text="Ver localización de Oficina Principal" OnClick="btnmaps_Click" />
</asp:Content>
