<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="BusquedaVehiculo.aspx.cs" Inherits="VentaAlquilerVehiculos.BusquedaVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Busqueda de Vehiculos"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <strong>Ingrese la marca o modelo del Vehiculo</strong>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="50px">
                     <asp:ListItem>Todos</asp:ListItem>
                      <asp:ListItem>Habilitados</asp:ListItem>
                       <asp:ListItem>Deshabilitados</asp:ListItem>
                 </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txtbusqueda" runat="server" ></asp:TextBox>
            </td>   
            <td>
                <asp:Button ID="btnbusqueda" runat="server" Text="Buscar" Height="70px" OnClick="btnbusqueda_Click" />
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblmensajebuquedanula" runat="server" Text="(No se Encontraron Resultados, Inicie una Nueva Busqueda)" Visible="false"></asp:Label>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="false" Visible="false">
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
            </td>
            <td>
               
                <asp:ImageButton ID="ImageButton1" runat="server" Height="85px" ImageAlign="Middle" ImageUrl="~/Imagenes/iconopdf.ico" Width="91px" OnClick="ImageButton1_Click" />
               
            </td>
        </tr>
    </table>
</asp:Content>
