using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio = new Service();
            GridView1.DataSource = servicio.obtenervehiculoshabilitados();
            GridView1.DataBind();
            Session.Add("idvehiculo", "0");
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["idvehiculo"] = GridView1.Rows[e.NewSelectedIndex].Cells[9].Text.ToString();
            if ((string)(Session["idvehiculo"]) != "0")
            {
                Server.Transfer("ModInVehiculo.aspx");
            }
        }
    }
}