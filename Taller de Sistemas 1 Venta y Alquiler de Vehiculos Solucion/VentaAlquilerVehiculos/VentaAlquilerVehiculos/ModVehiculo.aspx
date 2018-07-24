<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="ModVehiculo.aspx.cs" Inherits="VentaAlquilerVehiculos.ModVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Seleccione el Vehiculo que desea Modificar"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Motor" HeaderText="Motor"/>    
        <asp:BoundField DataField="CostoVenta" HeaderText="Costo de Venta"/>    
        <asp:BoundField DataField="CostoAlquiler" HeaderText="Costo de Alquiler por Semana"/>    
        <asp:BoundField DataField="CantidadStock" HeaderText="Cantidad"/>     
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="Motor" HeaderText="Motor"/> 
        <asp:BoundField DataField="AlquilerOVenta" HeaderText="Disponibilidad"/>
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº"/>
        <asp:ImageField DataImageUrlField="Imagen" ControlStyle-Height="100px" ControlStyle-Width="200px"  HeaderText="Vista">
        <ControlStyle Height="100px" Width="150px"></ControlStyle>
        </asp:ImageField>   
        </Columns>
    </asp:GridView>

</asp:Content>
