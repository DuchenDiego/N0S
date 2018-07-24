<%@ Page Title="" Language="C#" MasterPageFile="~/MenuInvitado.Master" AutoEventWireup="true" CodeBehind="HomeInvitado.aspx.cs" Inherits="VentaAlquilerVehiculos.HomeInvitado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Marcas y Modelos Asociados a la Empresa"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Selecciona un modelo para ver mas detalles</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
        <asp:BoundField DataField="Motor" HeaderText="Motor"/>       
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="Motor" HeaderText="Motor"/> 
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº"/>
        </Columns>
    </asp:GridView>
</asp:Content>
