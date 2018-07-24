<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="BajaVehiculo.aspx.cs" Inherits="VentaAlquilerVehiculos.BajaVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Seleccione el/los Vehiculos que desea dar de Baja"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:gridview id="grdauxsucursal" runat="server" Visible="false"></asp:gridview>
    <asp:GridView ID="GridView1" CssClass="subtitulos" runat="server" AutoGenerateColumns="false" CellPadding="4" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>    
        <asp:BoundField DataField="CostoVenta" HeaderText="Costo de Venta"/>    
        <asp:BoundField DataField="CostoAlquiler" HeaderText="Costo de Alquiler"/>       
        <asp:BoundField DataField="Dimensiones" HeaderText="Dimensiones"/> 
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="CantidadStock" HeaderText="Cantidad"/> 
        <asp:BoundField DataField="Motor" HeaderText="Cilindrada"/>
        <asp:BoundField DataField="Asientos" HeaderText="Numero de Asientos"/>
        <asp:BoundField DataField="AlquilerOVenta" HeaderText="Disponibilidad"/>
        <asp:BoundField DataField="ID_Sucursal" HeaderText="Sucursal Nº"/>
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº" Visible="true"/>
        </Columns>
    </asp:GridView> 


    <table style="width: 100%">
        <tr>
            <td colspan="2" style="height: 16px"><strong>Indique cuantos vehiculos desea dar de baja</strong></td>
        </tr>
        <tr>
            <td>Numero de Vehiculos disponibles de la Sucursal Seleccionada</td>
            <td><asp:TextBox ID="txtcantveselec" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Cantidad a dar de baja</td>
            <td>
                <asp:TextBox ID="txtcantbaja" runat="server" ></asp:TextBox></td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcantbaja" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
                
        </tr>
        <tr>
            <td><br></br></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnbaja" runat="server" Text="Dar de Baja" OnClick="btnbaja_Click" />

            </td>
        </tr>
    </table>

</asp:Content>
