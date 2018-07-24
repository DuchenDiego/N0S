<%@ Page Title="" Language="C#" MasterPageFile="~/MenuAlquiler.Master" AutoEventWireup="true" CodeBehind="VisorReporteAlquiler.aspx.cs" Inherits="VentaAlquilerVehiculos.VisorReporteAlquiler" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Seleccione una Opcion para el Reporte"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table style="width: 100%">
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnpdf" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/pdf.png" Width="100px" OnClick="imgbtnpdf_Click" />
            <td>
                <asp:Button ID="btnentregado" runat="server" Text="Confirmar Devolucion de Vehiculo" OnClick="btnentregado_Click" Visible="False" /></td>
                
            </td>
            <td>
                <asp:ImageButton ID="imgbtncorreo" runat="server" Height="100px" ImageUrl="~/Imagenes/mail.png" ImageAlign="Middle" OnClick="imgbtncorreo_Click" Visible="False" />
            </td>
        </tr>
         <tr>
             <td></br></td>
         </tr>
          <tr>
            <td colspan="2">
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" DisplayToolbar="False" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" ToolPanelView="None" DisplayStatusbar="False" EnableToolTips="False" HasDrilldownTabs="False" HasToggleGroupTreeButton="False" HasToggleParameterPanelButton="False" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdauxcliente" runat="server" Visible="false"></asp:GridView>
</asp:Content>
