using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
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
    public partial class BusquedaEmpleado : System.Web.UI.Page
    {
        Service servicio = new Service();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbusqueda_Click(object sender, EventArgs e)
        {
            string busqueda=txtbusqueda.Text;
            if(busqueda==string.Empty && DropDownList1.SelectedItem.Text=="Todos"){
                GridView3.DataSource=servicio.obtenerempleados();
                GridView3.DataBind();
                GridView3.Visible=true;
            }else if(busqueda==string.Empty && DropDownList1.SelectedItem.Text=="Habilitados"){
                GridView3.DataSource = servicio.obtenerempleadoshabilitados();
                GridView3.DataBind();
                GridView3.Visible = true;
            }else if(busqueda==string.Empty && DropDownList1.SelectedItem.Text=="Deshabilitados"){
                GridView3.DataSource = servicio.obtenerempleadosdeshabilitados();
                GridView3.DataBind();
                GridView3.Visible = true;
            }else if(DropDownList1.SelectedItem.Text=="Todos"){
                GridView3.DataSource = servicio.busquedaempleados(busqueda,busqueda);
                GridView3.DataBind();
                GridView3.Visible = true;
            }else if(DropDownList1.SelectedItem.Text=="Habilitados"){
                GridView3.DataSource = servicio.busquedaempleadoshabilitados(busqueda,busqueda);
                GridView3.DataBind();
                GridView3.Visible = true;
            }else if(DropDownList1.SelectedItem.Text=="Deshabilitados"){
                GridView3.DataSource = servicio.busquedaempleadosdeshabilitados(busqueda,busqueda);
                GridView3.DataBind();
                GridView3.Visible = true;
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
            //Generar Pdf
           Document doc=new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            // string path = this.Server.MapPath(".") + "Archivos\\MiArchivo.pdf";
            //PdfWriter wri = PdfWriter.GetInstance(doc,new FileStream("PdfsGenerados/ReporteEmpleados.pdf",FileMode.Create));
            String path = this.Server.MapPath(".") + "//PdfsGenerados//ReportesEmpleados.pdf";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(doc,file);
            //Inicio del Documento
            doc.Open();

            /////Imagenes/////
            iTextSharp.text.Image Banner = iTextSharp.text.Image.GetInstance("banner.png");
            iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("logo.png");
            Banner.ScaleToFit(500f,1000f);
            Banner.Border = iTextSharp.text.Rectangle.BOX;
            Banner.BorderColor = iTextSharp.text.BaseColor.GRAY;
            Banner.BorderWidth = 3f;
            Banner.Alignment = Element.ALIGN_CENTER;
            Logo.ScalePercent(20f);
            Logo.SetAbsolutePosition(350,50);
            doc.Add(Banner);
            doc.Add(Logo);
            //Paragraph parrafo = new Paragraph("WELCOME TO HELL\n WOOOOO");
            //doc.Add(parrafo);
            Paragraph saltos = new Paragraph("\n\n\n");
            doc.Add(saltos);

            /////Tabla con datos de gridview/////
            PdfPTable tabla = new PdfPTable(GridView3.Columns.Count);
            
            //Titulo
            Font fonttitulo=new Font();
            fonttitulo.SetFamily("COURIER");
            fonttitulo.SetStyle(1);
            PdfPCell celdatitulo = new PdfPCell(new Phrase("Reporte de Busqueda de Empleados",fonttitulo));
            celdatitulo.BackgroundColor = new iTextSharp.text.BaseColor(125, 127, 131);
            celdatitulo.Colspan = 10;
            celdatitulo.HorizontalAlignment = 1;
            tabla.AddCell(celdatitulo);
            //Headers
            Font fontheader = new Font();
            fontheader.SetFamily("COURIER");
            fontheader.SetStyle(2);
            PdfPCell celdahead1 = new PdfPCell(new Phrase("CI"));
            PdfPCell celdahead2 = new PdfPCell(new Phrase("Nombre"));
            PdfPCell celdahead3 = new PdfPCell(new Phrase("Apellido Paterno"));
            PdfPCell celdahead4 = new PdfPCell(new Phrase("Apellido Materno"));
            PdfPCell celdahead5 = new PdfPCell(new Phrase("Fecha de Nacimiento"));
            PdfPCell celdahead6 = new PdfPCell(new Phrase("Email"));
            PdfPCell celdahead7 = new PdfPCell(new Phrase("Celular"));
            PdfPCell celdahead8 = new PdfPCell(new Phrase("Latencia"));
            PdfPCell celdahead9 = new PdfPCell(new Phrase("Ocupacion"));
            PdfPCell celdahead10 = new PdfPCell(new Phrase("Estado"));
            celdahead1.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead3.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead5.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead7.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            celdahead9.BackgroundColor = new iTextSharp.text.BaseColor(6, 111, 98);
            tabla.AddCell(celdahead1);
            tabla.AddCell(celdahead2);
            tabla.AddCell(celdahead3);
            tabla.AddCell(celdahead4);
            tabla.AddCell(celdahead5);
            tabla.AddCell(celdahead6);
            tabla.AddCell(celdahead7);
            tabla.AddCell(celdahead8);
            tabla.AddCell(celdahead9);
            tabla.AddCell(celdahead10);
            //Llenado de tabla
            for(int i=0;i<GridView3.Rows.Count;i++){
                if(GridView3.Rows[i].RowType==DataControlRowType.DataRow){
                    for (int j = 0; j < GridView3.Columns.Count;j++ )
                    {
                        string celltext = Page.Server.HtmlDecode(GridView3.Rows[i].Cells[j].Text);
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
   
    }
}