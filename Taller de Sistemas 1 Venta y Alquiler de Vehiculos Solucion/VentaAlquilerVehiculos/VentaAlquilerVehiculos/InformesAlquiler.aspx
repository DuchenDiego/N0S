<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAlquiler.Master" AutoEventWireup="true" CodeBehind="InformesAlquiler.aspx.cs" Inherits="VentaAlquilerVehiculos.InformesAlquiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Alquileres Pasados y Pendientes"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h2>Alquileres</h2>
        <table style="width: 100%">
            <tr>
                <td>Buscar Alquiler pendiente por CI de Cliente</td>
                <td>
                    <asp:TextBox ID="txtbusqueda" runat="server" MaxLength="7"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtbusqueda" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
                    </td>
                <td>
                    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" OnClick="btnbuscar_Click" />
                </td>
            </tr>
            <tr>
                <td><br></br></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="grdalquileres" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" EnableModelValidation="True" OnSelectedIndexChanging="grdalquileres_SelectedIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="CI_Cliente" HeaderText="CI del Cliente"/>
                        <asp:BoundField DataField="FechaInicio" HeaderText="Fecha de Inicio" SortExpression="FechaInicio" DataFormatString="{0:d}" HtmlEncode=false />     
                        <asp:BoundField DataField="FechaFinal" HeaderText="Fecha Final" SortExpression="FechaFinal" DataFormatString="{0:d}" HtmlEncode=false/>
                        <asp:BoundField DataField="FechaA" HeaderText="Fecha del Alquiler" SortExpression="Fecha del Alquiler" DataFormatString="{0:d}" HtmlEncode=false/>       
                        <asp:BoundField DataField="TotalA" HeaderText="Costo de Alquiler"/>         
                        <asp:BoundField DataField="Plazo" HeaderText="Plazo en Dias"/> 
                        <asp:BoundField DataField="Estado" HeaderText="Estado"/> 
                        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo de Vehiculo"/> 
                     </Columns>
                     </asp:GridView>
                </td>   
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/iconopdf.ico" OnClick="ImageButton1_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
