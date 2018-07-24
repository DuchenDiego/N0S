<%@ Page Title="" Language="C#" MasterPageFile="~/MenuVenta.Master" AutoEventWireup="true" CodeBehind="VisorFactura.aspx.cs" Inherits="VentaAlquilerVehiculos.VisorFactura" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" CssClass="titulo" runat="server" Text="Vista de Factura"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table style="width: 100%">
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnpdf" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Imagenes/pdf.png" Width="100px" OnClick="imgbtnpdf_Click" />
            </td>
        </tr>
        <tr>
             <td></br></td>
         </tr>
        <tr>
            <td>
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" DisplayStatusbar="False" DisplayToolbar="False" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" EnableToolTips="False" HasDrilldownTabs="False" HasToggleGroupTreeButton="False" HasToggleParameterPanelButton="False" ToolPanelView="None" />
            </td>
        </tr>
    </table>

</asp:Content>
