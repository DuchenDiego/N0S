using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
namespace VentaAlquilerVehiculos
{
    public partial class InformesAlquiler : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdalquileres.DataSource = servicio.obteneralquileres();
            grdalquileres.DataBind();
           /* List<DateTime> FechasFinales = new List<DateTime>();
            foreach (GridViewRow row in grdalquileres.Rows)
            {
                DateTime FF = Convert.ToDateTime(row.Cells[3].Text);
                DateTime FechaActual = DateTime.Today;
                if (FechaActual >= FF)
                {
                    
                }
            }*/
            Session.Add("ciclienter", "0");
            Session.Add("fechafinalseleccionado","na");
            Session.Add("estadoselec","na");
            Session.Add("idvehicselec","0");
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbusqueda.Text == string.Empty)
            {
                grdalquileres.DataSource = servicio.obteneralquileres();
                grdalquileres.DataBind();
            }
            else
            {
                int cicl = Convert.ToInt32(txtbusqueda.Text);
                grdalquileres.DataSource = servicio.obteneralquilerporcicliente(cicl);
                grdalquileres.DataBind();
            }


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            grdalquileres.Rows[0].Visible = false;
            //Generar Pdf
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            // string path = this.Server.MapPath(".") + "Archivos\\MiArchivo.pdf";
            //PdfWriter wri = PdfWriter.GetInstance(doc,new FileStream("PdfsGenerados/ReporteEmpleados.pdf",FileMode.Create));
            String path = this.Server.MapPath(".") + "//PdfsGenerados//ReportesAlquileres.pdf";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(doc, file);
            //Inicio del Documento
            doc.Open();

            /////Imagenes/////
            iTextSharp.text.Image Banner = iTextSharp.text.Image.GetInstance("banner.png");
            iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("logo.png");
            Banner.ScaleToFit(500f, 1000f);
            Banner.Border = iTextSharp.text.Rectangle.BOX;
            Banner.BorderColor = iTextSharp.text.BaseColor.GRAY;
            Banner.BorderWidth = 3f;
            Banner.Alignment = Element.ALIGN_CENTER;
            Logo.ScalePercent(20f);
            Logo.SetAbsolutePosition(350, 50);
            doc.Add(Banner);
            doc.Add(Logo);
            //Paragraph parrafo = new Paragraph("WELCOME TO HELL\n WOOOOO");
            //doc.Add(parrafo);
            Paragraph saltos = new Paragraph("\n\n\n");
            doc.Add(saltos);

            /////Tabla con datos de gridview/////
            PdfPTable tabla = new PdfPTable(grdalquileres.Columns.Count);

            //Titulo
            Font fonttitulo = new Font();
            fonttitulo.SetFamily("COURIER");
            fonttitulo.SetStyle(1);
            PdfPCell celdatitulo = new PdfPCell(new Phrase("Reporte de Busqueda de Alquileres", fonttitulo));
            celdatitulo.BackgroundColor = new iTextSharp.text.BaseColor(125, 127, 131);
            celdatitulo.Colspan = 10;
            celdatitulo.HorizontalAlignment = 1;
            tabla.AddCell(celdatitulo);
            //Headers
            Font fontheader = new Font();
            fontheader.SetFamily("COURIER");
            fontheader.SetStyle(2);
            PdfPCell celdahead1 = new PdfPCell(new Phrase(""));
            PdfPCell celdahead2 = new PdfPCell(new Phrase("Ci Del Cliente"));
            PdfPCell celdahead3 = new PdfPCell(new Phrase("Fecha De Inicio"));
            PdfPCell celdahead4 = new PdfPCell(new Phrase("Fecha Final"));
            PdfPCell celdahead5 = new PdfPCell(new Phrase("Fecha de Alquiler"));
            PdfPCell celdahead6 = new PdfPCell(new Phrase("Costo de Alquiler"));
            PdfPCell celdahead7 = new PdfPCell(new Phrase("Plazo En Dias"));
            celdahead1.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead3.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead5.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead7.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            tabla.AddCell(celdahead1);
            tabla.AddCell(celdahead2);
            tabla.AddCell(celdahead3);
            tabla.AddCell(celdahead4);
            tabla.AddCell(celdahead5);
            tabla.AddCell(celdahead6);
            tabla.AddCell(celdahead7);
            //Llenado de tabla
            for (int i = 0; i < grdalquileres.Rows.Count; i++)
            {
                if (grdalquileres.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    for (int j = 0; j < grdalquileres.Columns.Count; j++)
                    {
                        string celltext = Page.Server.HtmlDecode(grdalquileres.Rows[i].Cells[j].Text);
                        tabla.AddCell(new Phrase(celltext));

                    }
                }
            }

            /* for (int j = 0; j < GridView3.Columns.Count; j++)
             {
                 tabla.AddCell(new Phrase(GridView3.Columns[j].HeaderText));
             }
             tabla.HeaderRows = 1;
             for (int i = 0; i < GridView3.Rows.Count;i++)
             {
                 for (int k = 0; k < GridView3.Columns.Count;k++ )
                 {
                     if (GridView3[k, i].Value != null)
                     {

                     }

                 }
             }*/
            doc.Add(tabla);
            doc.Close();
            Process.Start(path);
            //System.Diagnostics.Process.Start("ReportesEmpleados.pdf");
        }

        protected void grdalquileres_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["ciclienter"] = grdalquileres.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();
            Session["fechafinalseleccionado"] = grdalquileres.Rows[e.NewSelectedIndex].Cells[3].Text.ToString();
            Session["estadoselec"] = grdalquileres.Rows[e.NewSelectedIndex].Cells[7].Text.ToString();
            Session["idvehicselec"] = grdalquileres.Rows[e.NewSelectedIndex].Cells[8].Text.ToString();
            if ((string)(Session["ciclienter"]) != "0")
            {
                Server.Transfer("VisorReporteAlquiler.aspx");
            }
        }
    }
}