<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="BajaEmpleado.aspx.cs" Inherits="VentaAlquilerVehiculos.BajaEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Seleccione la Sucursal que desea dar de Baja"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <asp:GridView ID="GridView1" CssClass="subtitulos" runat="server" AutoGenerateColumns="false" CellPadding="4" AutoGenerateSelectButton="true" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
        <Columns>
        <asp:BoundField DataField="CI_Empleado" HeaderText="CI"/>     
        <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>    
        <asp:BoundField DataField="ApellidoP" HeaderText="Apellido Paterno"/>    
        <asp:BoundField DataField="Ocupacion" HeaderText="Ocupacion"/>       
        </Columns>
    </asp:GridView> 
</asp:Content>
