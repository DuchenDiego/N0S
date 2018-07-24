<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="ModSucursal.aspx.cs" Inherits="VentaAlquilerVehiculos.ModSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Modificacion de Sucursal"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView2" CssClass="subtitulos" runat="server" AutoGenerateColumns="false" CellPadding="4" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView2_SelectedIndexChanged1" >
        <Columns>
        <asp:BoundField DataField="ID_Sucursal" HeaderText="Numero"/>     
        <asp:BoundField DataField="Direccion" HeaderText="Direccion"/>    
        <asp:BoundField DataField="Zona" HeaderText="Zona"/>    
        <asp:BoundField DataField="Telefono" HeaderText="Telefono"/>    
        <asp:BoundField DataField="CantidadVehiculos" HeaderText="CantidadVehiculos"/>     
        <asp:BoundField DataField="CantidadMaxVehiculos" HeaderText="CantidadMaxVehiculos"/>    
        </Columns>
    </asp:GridView> 
</asp:Content>