<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="BajaSucursal.aspx.cs" Inherits="VentaAlquilerVehiculos.BajaSucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label runat="server" CssClass="titulo" text="Selecciona la Sucursal que desea Dar de Baja"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" CssClass="subtitulos" runat="server" AutoGenerateColumns="false" CellPadding="4" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
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
