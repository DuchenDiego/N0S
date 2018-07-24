using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
using System.Net;
using System.Net.Mail;
using System.Text;
namespace VentaAlquilerVehiculos
{
    public partial class VisorReporteAlquiler : System.Web.UI.Page
    {
        Service servicio = new Service();
        //Crear instancia del reporte
        ReporteAlquiler objreportealq = new ReporteAlquiler();
        protected void Page_Load(object sender, EventArgs e)
        {
            // recibir ci cliente y tomarlo como parametro para el reporte, adjuntar
            int ci=Convert.ToInt32((Session["ciclienter"]));
            objreportealq.SetParameterValue("@CICL",ci);
            CrystalReportViewer1.ReportSource = objreportealq;
            //recibir variables para opciones de entrega o correo
            DateTime fechafinal = Convert.ToDateTime(Session["fechafinalseleccionado"]);
            string estadoalq = Convert.ToString(Session["estadoselec"]);
            // comparaciones para habilitacion de botones
            DateTime fechaactual = DateTime.Today;
            if (fechaactual >= fechafinal && estadoalq=="Pendiente")
            {
                btnentregado.Visible = true;
                imgbtncorreo.Visible = true;
            }
            // gridview auxiliar de cliente seleccionado
            grdauxcliente.DataSource = servicio.obtenerclienteporid(ci);
            grdauxcliente.DataBind();
            
        }

        protected void imgbtnpdf_Click(object sender, ImageClickEventArgs e)
        {
            objreportealq.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,Response,true,"Reporte Completo Alquiler");
        }

        protected void btnentregado_Click(object sender, EventArgs e)
        {
            int idvehic = Convert.ToInt32(Session["idvehicselec"]);
            int ci = Convert.ToInt32((Session["ciclienter"]));
            Boolean resultado2 = servicio.aumentovehiculoalquiler(idvehic);
            Boolean resultado = servicio.devolveralquiler(ci);
            if (resultado == true && resultado2 == true)
            {
                Server.Transfer("InformesAlquiler.aspx");
            }
        }

        protected void imgbtncorreo_Click(object sender, ImageClickEventArgs e)
        {
            string nombrecli=grdauxcliente.Rows[0].Cells[1].Text.ToString();
            string apellidopcli=grdauxcliente.Rows[0].Cells[2].Text.ToString();
            string apellidomcli=grdauxcliente.Rows[0].Cells[3].Text.ToString();
            string email=grdauxcliente.Rows[0].Cells[5].Text.ToString();
            string emailremitente = "pliskinauditore@gmail.com";
            string passremitente = "jackpot.";
            //creacion del correo e
            MailMessage correo = new MailMessage();
            SmtpClient envio = new SmtpClient();
            correo.To.Clear();
            correo.Body = "";
            correo.Subject = "";
            correo.Body = "Estimado Cliente\n De parte de la empresa N2O se le recuerda que el plazo de su alquiler finalizó, favor de presentarse en alguna de las sucursales de la empresa \n Atentamente N2O";
            correo.Subject = "Plazo de Alquiler Finalizado";
            correo.IsBodyHtml = true;
            correo.To.Add(email.Trim());
            System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment("D://Descargas//Reporte Completo Alquiler.pdf");
            correo.Attachments.Add(archivo);
            correo.From = new MailAddress(emailremitente);
            envio.Credentials = new NetworkCredential(emailremitente,passremitente);
            //Datos no modificables para la conexion
            envio.Host = "smtp.gmail.com";
            envio.Port = 587;
            envio.EnableSsl = true;
            //Envio del correo
            envio.Send(correo);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Correo de Plazo Finalizado Enviado a Cliente')", true);
        }
    }
}