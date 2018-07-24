<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAdmin.Master" AutoEventWireup="true" CodeBehind="RegistroVehiculo.aspx.cs" Inherits="VentaAlquilerVehiculos.RegistroVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Registro de Vehiculo"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
    <table style="width: 100%">
        <tr>
            <td>Marca</td>
            <td>
                <asp:textbox id="txtmarca" runat="server"></asp:textbox>
                <asp:requiredfieldvalidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtmarca"></asp:requiredfieldvalidator>
                 
            </td>
        </tr>
        <tr>
            <td>Modelo</td>
            <td>  <asp:textbox id="txtmodelo" runat="server"></asp:textbox>
                <asp:requiredfieldvalidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtmodelo"></asp:requiredfieldvalidator>
                 
        </tr>
        <tr>
            <td>Cantidad</td>
            <td> <asp:textbox id="txtcantidad" runat="server"></asp:textbox><asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtcantidad"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtcantidad" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Url de Imagen</td>
            <td><asp:textbox id="txturlimg" runat="server"></asp:textbox><asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txturlimg"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Url de Modelo</td>
            <td><asp:textbox id="txtulrmod" runat="server"></asp:textbox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El campo debe tener formato de direccion url" ControlToValidate="txtulrmod" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtulrmod"></asp:RequiredFieldValidator></td>
            
        </tr>
        <tr>
            <td>Costo Venta(US$)</td>
            <td><asp:textbox id="txtcostoventa" runat="server"></asp:textbox><asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtcostoventa"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtcostoventa" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]+([,][0-9]+)?$">El campo debe contener solo numeros</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
        <td></br></br></td>
        </tr>
            <tr>
            <td>Disponibilidad</td>
            <td>
                <asp:DropDownList ID="ddldisponibilidad" runat="server">
                    <asp:ListItem>Alquiler</asp:ListItem>
                    <asp:ListItem>Venta</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
       <td></br></br></td>
        </tr>
        <tr>
            <td>Largo(Expresado en Milimetros)</td>
            <td><asp:textbox id="txtdimension"  runat="server" ></asp:textbox><asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtdimension"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtdimension" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
       <td></br></br></td>
        </tr>
        <tr>
            <td>Transmision</td>
            <td>
                <asp:dropdownlist ID="ddltrans" runat="server">
                    <asp:ListItem>Manual</asp:ListItem>
                    <asp:ListItem>Automatico</asp:ListItem>
                </asp:dropdownlist>
            </td>
        </tr>
        <tr>
        <td></br></br></td>
        </tr>
        <tr>
            <td>Seguridad</td>
            <td>   
                <table style="width: 100%">
                    <tr>
                        <td><asp:CheckBox ID="CheckBox1" runat="server" Text="Doble Airbag" Width="50px"/></td>
                        <td><asp:CheckBox ID="CheckBox2" runat="server" text="Barras Protectoras" Width="50px"/></td>
                        <td><asp:CheckBox ID="CheckBox3" runat="server" Text="Sistema Antirrobo" Width="50px" /></td>
                        <td><asp:CheckBox ID="CheckBox4" runat="server" Text="Seguro Puertas para Niño" Width="50px" /></td>
                    </tr>
                </table>
        </tr>
        <tr>
            <td>Cilindrada de Motor(cc)</td>
            <td><asp:textbox id="txtmotor" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtmotor"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtmotor" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Asientos</td>
            <td>
                <asp:DropDownList ID="ddlasientos" runat="server">
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Sucursal</td>
            <td>
                <asp:DropDownList ID="ddlsuc" runat="server" DataSourceID="SqlDataSource1" DataTextField="Direccion" DataValueField="Direccion" OnSelectedIndexChanged="ddlsuc_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VentaAlquilerConnectionString %>" SelectCommand="SELECT [Direccion] FROM [Sucursal] WHERE ([Estado] = @Estado)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Habilitado" Name="Estado" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
        <td></br></br></td>
        </tr>
        <tr>
            <td>
                <input id="Reset1" type="reset" value="reset" /></td>
            <td>
                <asp:Button ID="btnregistro" runat="server" Text="Registrar" OnClick="btnregistro_Click" /></td>
        </tr>
    </table>

</asp:Content>
