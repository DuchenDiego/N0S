<%@ Page Title="" Language="C#" MasterPageFile="~/MenuVenta.Master" AutoEventWireup="true" CodeBehind="InformeVentas.aspx.cs" Inherits="VentaAlquilerVehiculos.InformeVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Lista de Ventas"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h2>Seleccione una venta para ver su factura correspondiente</h2>
        <table style="width: 100%">
            <tr>
                <td>Buscar Venta pendiente por CI de Cliente</td>
                <td>
                    <asp:TextBox ID="txtbusqueda" runat="server" MaxLength="7"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtbusqueda" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
                    </td>
                <td>
                    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" OnClick="btnbuscar_Click"  />
                </td>
            </tr>
            <tr>
                <td><br></br></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="grdventas" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" EnableModelValidation="True" OnSelectedIndexChanging="grdventas_SelectedIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="CI_Cliente" HeaderText="CI del Cliente"/>
                        <asp:BoundField DataField="FechaV" HeaderText="Fecha de Venta" SortExpression="FechaV" DataFormatString="{0:d}" HtmlEncode=false />           
                        <asp:BoundField DataField="CI_Empleado" HeaderText="CI del Empleado"/>         
                        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo de Vehiculo"/> 
                     </Columns>
                     </asp:GridView>
                </td>   
            </tr>
        </table>
</asp:Content>
