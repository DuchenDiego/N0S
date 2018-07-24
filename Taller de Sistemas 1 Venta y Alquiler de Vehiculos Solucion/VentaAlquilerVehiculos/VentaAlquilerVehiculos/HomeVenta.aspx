<%@ Page Title="" Language="C#" MasterPageFile="~/MenuVenta.Master" AutoEventWireup="true" CodeBehind="HomeVenta.aspx.cs" Inherits="VentaAlquilerVehiculos.HomeVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Vehiculos Disponibles para Venta"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
        <asp:BoundField DataField="Motor" HeaderText="Motor"/>    
        <asp:BoundField DataField="CostoVenta" HeaderText="Costo de Venta"/>    
        <asp:BoundField DataField="CostoAlquiler" HeaderText="Costo de Alquiler por Semana"/>    
        <asp:BoundField DataField="CantidadStock" HeaderText="Cantidad"/>     
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="Motor" HeaderText="Motor"/> 
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº"/>
        <asp:ImageField DataImageUrlField="Imagen" ControlStyle-Height="100px" ControlStyle-Width="250px"  HeaderText="Vista">
        <ControlStyle Height="100px" Width="150px"></ControlStyle>
        </asp:ImageField>   
        </Columns>
    </asp:GridView>
</asp:Content>
