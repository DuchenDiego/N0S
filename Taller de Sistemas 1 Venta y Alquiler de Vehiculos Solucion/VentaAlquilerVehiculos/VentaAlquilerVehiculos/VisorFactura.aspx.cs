using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace VentaAlquilerVehiculos
{
    public partial class VisorFactura : System.Web.UI.Page
    {
        Factura objfactura= new Factura();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ci = Convert.ToInt32((Session["ciclienter"]));
            objfactura.SetParameterValue("@CICL", ci);
            CrystalReportViewer1.ReportSource = objfactura;
        }

        protected void imgbtnpdf_Click(object sender, ImageClickEventArgs e)
        {
            objfactura.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Factura");
        }
    }
}