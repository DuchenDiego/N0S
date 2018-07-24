<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="VentaAlquilerVehiculos.HomeAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="General"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table border style="width: 100%; border:dotted">
        <tr>
            <td><h1>Sucursales</h1></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="True">
                    <Columns>
                            <asp:BoundField DataField="ID_Sucursal" HeaderText="Numero"/>
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion"/>
                            <asp:BoundField DataField="Zona" HeaderText="Zona"/>
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono"/>
                            <asp:BoundField DataField="CantidadVehiculos" HeaderText="Cantidad de Vehiculos"/>
                            <asp:BoundField DataField="CantidadMaxVehiculos" HeaderText="Cantidad Maxima de Vehiculos"/>
                            <asp:BoundField DataField="Estado" HeaderText="Estado"/>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td><h1>Empleados</h1></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView2"  runat="server" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="True">
                    <Columns>
                            <asp:BoundField DataField="CI_Empleado" HeaderText="CI"/>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                            <asp:BoundField DataField="ApellidoP" HeaderText="ApellidoP"/>
                            <asp:BoundField DataField="ApellidoM" HeaderText="ApellidoM"/>    
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" DataFormatString="{0:d}" HtmlEncode=false />
                            <asp:BoundField DataField="Email" HeaderText="Email"/>  
                            <asp:BoundField DataField="Celular" HeaderText="Celular"/> 
                            <asp:BoundField DataField="Estado" HeaderText="Estado"/>    
                            <asp:BoundField DataField="Latencia" HeaderText="Latencia"/>    
                            <asp:BoundField DataField="Ocupacion" HeaderText="Ocupacion"/>        
                        </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td><h1>Vehiculos</h1></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="false" CellPadding="4" EnableModelValidation="True">
                    <Columns>
                            <asp:BoundField DataField="ID_Vehiculo" HeaderText="Numero"/>
                            <asp:BoundField DataField="CostoVenta" HeaderText="Costo de Venta"/>
                            <asp:BoundField DataField="CostoAlquiler" HeaderText="Costo de Alquiler por Semana"/> 
                            <asp:BoundField DataField="CantidadStock" HeaderText="Cantidad"/>
                            <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
                            <asp:BoundField DataField="Motor" HeaderText="Motor"/>
                            <asp:BoundField DataField="Marca" HeaderText="Marca"/>
                            <asp:BoundField DataField="AlquilerOVenta" HeaderText="Disponibilidad"/>
                            <asp:BoundField DataField="Estado" HeaderText="Estado"/> 
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>
