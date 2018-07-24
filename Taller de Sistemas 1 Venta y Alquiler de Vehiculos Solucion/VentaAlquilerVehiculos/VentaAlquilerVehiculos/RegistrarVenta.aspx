<%@ Page Title="" Language="C#" MasterPageFile="~/MenuVenta.Master" AutoEventWireup="true" CodeBehind="RegistrarVenta.aspx.cs" Inherits="VentaAlquilerVehiculos.RegistrarVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Registro de Nueva Venta"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h2>Busqueda o Registro de cliente </h2>

     <table style="width: 100%">
         <tr>
             <td>
                 <asp:Button ID="btnbuscarci" runat="server" Text="Buscar Cliente" OnClick="btnbuscarci_Click" />
             </td>
             <td>
                 <asp:TextBox ID="txtcic" runat="server" MaxLength="7"  ></asp:TextBox>
                 <strong>(Realice la busqueda del cliente por CI)</strong></br>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtcic" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
             </td>
         </tr>
    </table>    
     <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="CI del Cliente" Visible="true"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtci" runat="server" Visible="true" MaxLength="7"></asp:TextBox>
                <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtci"></asp:RequiredFieldValidator>-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtci" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nombre" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtnombre" runat="server" Visible="true"></asp:TextBox>
               <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtnombre"></asp:RequiredFieldValidator>-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnombre" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Apellido Paterno" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtapp" runat="server" Visible="true"></asp:TextBox>
               <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtapp"></asp:RequiredFieldValidator>-->
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtapp" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Apellido Materno" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtapm" runat="server" Visible="true"></asp:TextBox>
                <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtapm"></asp:RequiredFieldValidator>-->
             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtapm" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Celular" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtcel" runat="server" Visible="true" MaxLength="7"></asp:TextBox>
              <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtcel"></asp:RequiredFieldValidator>-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtcel" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtemail" runat="server" Visible="true"></asp:TextBox>
              <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtemail"></asp:RequiredFieldValidator>-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtemail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">El campo debe tener formato de correo electronico</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Direccion" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtdireccion" runat="server" Visible="true"></asp:TextBox>
               <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtdireccion"></asp:RequiredFieldValidator>-->
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Numero de Cuenta Bancaria" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtnumbanc" runat="server" Visible="true"></asp:TextBox>
               <!-- <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtnumbanc"></asp:RequiredFieldValidator>-->
            </td>
        </tr>
    </table>
    <br></br>
    <br></br>
    <h2>Seleccione el vehiculo </h2>
    <asp:GridView ID="grdvehiculos" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" CellSpacing="5" OnSelectedIndexChanging="grdvehiculos_SelectedIndexChanging"  >
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
        <asp:BoundField DataField="Motor" HeaderText="Motor"/>       
        <asp:BoundField DataField="CostoVenta" HeaderText="Costo de Venta(Usd)"/>         
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº"/>
        <asp:ImageField DataImageUrlField="Imagen" ControlStyle-Height="100px" ControlStyle-Width="200px"  HeaderText="Vista">
        <ControlStyle Height="100px" Width="150px"></ControlStyle>
        </asp:ImageField>   
        </Columns>
    </asp:GridView>
    <br></br>
    <br></br>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Button ID="btnregistrarventa" runat="server" Text="Registrar Venta" OnClick="btnregistrarventa_Click" />
            </td>
            <td>
                <asp:Button ID="btngenerarfactura" runat="server" Text="Generar Factura" OnClick="btngenerarfactura_Click" Visible="false" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdauxempleado" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxcliente" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxvehiculo" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxauxcliente" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxventa" runat="server" Visible="false"></asp:GridView>
</asp:Content>
