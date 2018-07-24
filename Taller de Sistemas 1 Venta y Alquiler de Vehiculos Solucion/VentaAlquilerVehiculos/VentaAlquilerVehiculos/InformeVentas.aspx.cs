using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class InformeVentas : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdventas.DataSource = servicio.obtenerventas();
            grdventas.DataBind();
            Session.Add("ciclienter", "0");
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbusqueda.Text == string.Empty)
            {
                grdventas.DataSource = servicio.obtenerventas();
                grdventas.DataBind();
            }
            else
            {
                int cicl = Convert.ToInt32(txtbusqueda.Text);
                grdventas.DataSource = servicio.obtenerventaporcicliente(cicl);
                grdventas.DataBind();
            }
        }

        protected void grdventas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["ciclienter"] = grdventas.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();
            if ((string)(Session["ciclienter"]) != "0")
            {
                Server.Transfer("VisorFactura.aspx");
            }
        }
    }
}