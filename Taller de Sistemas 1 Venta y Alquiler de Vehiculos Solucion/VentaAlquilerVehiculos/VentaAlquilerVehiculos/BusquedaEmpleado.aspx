<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="BusquedaEmpleado.aspx.cs" Inherits="VentaAlquilerVehiculos.BusquedaEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Busqueda de Empleados"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <strong>Ingrese el Nombre o Apellido de Empleado</strong>
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
                <asp:Button ID="btnbusqueda" runat="server" Text="Buscar" OnClick="btnbusqueda_Click" Height="70px" />
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblmensajebuquedanula" runat="server" Text="(No se Encontraron Resultados, Inicie una Nueva Busqueda)" Visible="false"></asp:Label>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="false" Visible="false">
                 <Columns>
                      <asp:BoundField DataField="CI_Empleado" HeaderText="CI"/>     
                      <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>    
                      <asp:BoundField DataField="ApellidoP" HeaderText="Apellido Paterno"/>    
                      <asp:BoundField DataField="ApellidoM" HeaderText="Apellido Materno"/>  
                      <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" SortExpression="FechaNacimiento" DataFormatString="{0:d}" HtmlEncode=false/>  
                      <asp:BoundField DataField="Email" HeaderText="Email"/>
                      <asp:BoundField DataField="Celular" HeaderText="Celular"/>
                      <asp:BoundField DataField="Latencia" HeaderText="Latencia"/>
                      <asp:BoundField DataField="Ocupacion" HeaderText="Ocupacion"/>
                      <asp:BoundField DataField="Estado" HeaderText="Estado"/>        
                  </Columns>
                </asp:GridView>
            </td>
            <td>
               
                <asp:ImageButton ID="ImageButton1" runat="server" Height="85px" ImageAlign="Middle" ImageUrl="~/Imagenes/iconopdf.ico" Width="91px" OnClick="ImageButton1_Click" />
               
            </td>
        </tr>
    </table>
</asp:Content>
