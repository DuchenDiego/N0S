<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAlquiler.Master" AutoEventWireup="true" CodeBehind="RegistrarAlquiler.aspx.cs" Inherits="VentaAlquilerVehiculos.RegistrarAlquiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label ID="Label1" runat="server" CssClass="titulo" text="Registro de Nuevo Alquiler"></asp:label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%=txtfechainicio.ClientID %>').datepicker(
               {

                   dateFormat: 'dd,mm, yy',
                   minDate: '0',
                   changeMonth: true,
                   numberOfMonths: 1,
                   dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                   monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr',
                       'May', 'Jun', 'Jul', 'Ago',
                       'Sep', 'Oct', 'Nov', 'Dic']
               });
             $('#<%=txtfechafinal.ClientID %>').datepicker(
              {

                  dateFormat: 'dd,mm, yy',
                  minDate: '+3D',
                  changeMonth: true,
                  numberOfMonths: 1,
                  dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                  monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr',
                      'May', 'Jun', 'Jul', 'Ago',
                      'Sep', 'Oct', 'Nov', 'Dic']
              });
         });
        </script>
        <style type="text/css">
            .ui-datepicker {
                font-size: 10pt !important;
            }
            .auto-style1 {
                width: 100%;
            }
            </style>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
     <script type="text/javascript">
         google.charts.load("current", { packages: ["calendar"] });
         google.charts.setOnLoadCallback(drawChart);

         function drawChart() {
             var dataTable = new google.visualization.DataTable();
             dataTable.addColumn({ type: 'date', id: 'Date' });
             dataTable.addColumn({ type: 'number', id: 'Won/Loss' });
             dataTable.addRows([
                [new Date(2016, 1, 1), 0],
                [new Date(2016, 1, 2), 1],
             ]);
            // var fechasrecibidas = [<%=FechasDefinitivas%>];
             //for (i = 0; i <= fechasrecibidas.length;i++){
              //   dataTable.addRows([
               // [new Date(fechasrecibidas), 1],
                 //]);
             //}
             var chart = new google.visualization.Calendar(document.getElementById('calendariochart'));

             var options = {
                 title: 'Visualizacion de Fechas Pre-Alquiler',
                 height: 350,
                 calendar: {
                     dayOfWeekLabel: {
                         fontName: 'Times-Roman',
                         fontSize: 12,
                         color: '#1a8763',
                         bold: true,
                         italic: true,
                     },
                     dayOfWeekRightSpace: 10,
                     daysOfWeek: 'DLMMJVS',
                 }
             };

             chart.draw(dataTable, options);
         }
    </script>
    <h2>Busqueda o Registro de cliente </h2>

     <table class="auto-style1">
         <tr>
             <td><strong>(Realice la busqueda del cliente por CI)</strong>
                 <asp:TextBox ID="txtcic" runat="server" MaxLength="7"  ></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtcic" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator></td>
             <td><asp:Button ID="btnbuscarci" runat="server" Text="Buscar Cliente" OnClick="btnbuscarci_Click" /></td>
         </tr>
     </table>
     <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="CI del Cliente" Visible="true"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtci" runat="server" Visible="true" MaxLength="7"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtci"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtci" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nombre" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtnombre" runat="server" Visible="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtnombre"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnombre" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Apellido Paterno" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtapp" runat="server" Visible="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtapp"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtapp" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Apellido Materno" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtapm" runat="server" Visible="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtapm"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtapm" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z_áéíóúñ\s]*$">Este campo solo puede contener letras</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Celular" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtcel" runat="server" Visible="true" MaxLength="7"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtcel"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtcel" ErrorMessage="RegularExpressionValidator" ValidationExpression="^\d+$">El campo debe contener solo numeros</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtemail" runat="server" Visible="true"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtemail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">El campo debe tener formato de correo electronico</asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Direccion" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtdireccion" runat="server" Visible="true"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtdireccion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Numero de Cuenta Bancaria" Visible="true"></asp:Label></td>
            <td><asp:TextBox ID="txtnumbanc" runat="server" Visible="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtnumbanc"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <br></br>
    <br></br>
    <h2>Seleccione el vehiculo </h2>
    <asp:GridView ID="grdvehiculos" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" CellSpacing="5" OnSelectedIndexChanging="grdvehiculos_SelectedIndexChanging">
        <Columns>
        <asp:BoundField DataField="Marca" HeaderText="Marca"/>     
        <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
        <asp:BoundField DataField="Motor" HeaderText="Motor"/>       
        <asp:BoundField DataField="CostoAlquiler" HeaderText="Costo de Alquiler por Semana"/>         
        <asp:BoundField DataField="Transmision" HeaderText="Transmision"/> 
        <asp:BoundField DataField="ID_Vehiculo" HeaderText="Grupo Nº"/>
        <asp:ImageField DataImageUrlField="Imagen" ControlStyle-Height="100px" ControlStyle-Width="200px"  HeaderText="Vista">
        <ControlStyle Height="100px" Width="150px"></ControlStyle>
        </asp:ImageField>   
        </Columns>
    </asp:GridView>
    <br></br>
    <br></br>
    <h2>Ingrese las Fechas del Alquiler</h2>
    <table style="width: 100%">
        <tr>
            <td>Ingrese la Fecha de Inicio</td>
            <td>Ingrese la Fecha Final</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtfechainicio" runat="server"></asp:TextBox>
                <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtfechainicio"></asp:RequiredFieldValidator>-->
            </td>
            <td>
                <asp:TextBox ID="txtfechafinal" runat="server"></asp:TextBox>
                 <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtfechafinal"></asp:RequiredFieldValidator>-->
            </td>
        </tr>
        <tr>
            <td><br></br></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btngenerarvista" runat="server" Text="Generar la vista del Plazo de los dias" OnClick="btngenerarvista_Click" Visible="false" />
            </td>
        </tr>
        <tr>
            <td><br></br></td>
        </tr>
        <tr>
            <td colspan="2"><!--<div id="calendariochart"></div>--></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnpreparareserva" runat="server" Text="Registrar Alquiler" OnClick="btnpreparareserva_Click" OnClientClick="return confirm('Esta seguro de registrar el nuevo Alquiler?')" /></td>
        </tr>
    </table>

    <asp:GridView ID="grdauxcliente" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxempleado" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxalquiler" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxvehiculo" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="grdauxauxcliente" runat="server" Visible="false"></asp:GridView>
   </asp:Content>
