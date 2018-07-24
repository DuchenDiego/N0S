using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using System.Drawing.Imaging;
namespace VentaAlquilerVehiculos
{
    public partial class DetalleVehicInv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio=new Service();
            int idvehic = Convert.ToInt32((Session["idvehicinvselec"]));
            grdauxvehicselec.DataSource = servicio.obtenervehiculoporid(idvehic);
            grdauxvehicselec.DataBind();
            //Codigo QR
            string urlmodelo = grdauxvehicselec.Rows[0].Cells[3].Text.ToString();
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img= encoder.Encode(urlmodelo);
            img.Save(AppDomain.CurrentDomain.BaseDirectory+"qrcode.jpg", ImageFormat.Jpeg);
            imgcodigoqr.ImageUrl = "qrcode.jpg";
            //
            imgfotovehic.ImageUrl = grdauxvehicselec.Rows[0].Cells[7].Text.ToString();
            Label2.Text = grdauxvehicselec.Rows[0].Cells[11].Text.ToString();
            Label3.Text = grdauxvehicselec.Rows[0].Cells[8].Text.ToString();
            Label4.Text = grdauxvehicselec.Rows[0].Cells[5].Text.ToString();
            Label5.Text = grdauxvehicselec.Rows[0].Cells[9].Text.ToString();
            Label6.Text = grdauxvehicselec.Rows[0].Cells[10].Text.ToString();
            Label7.Text = grdauxvehicselec.Rows[0].Cells[12].Text.ToString();
            Label8.Text = grdauxvehicselec.Rows[0].Cells[1].Text.ToString();
            Label9.Text = grdauxvehicselec.Rows[0].Cells[2].Text.ToString();
        }
    }
}