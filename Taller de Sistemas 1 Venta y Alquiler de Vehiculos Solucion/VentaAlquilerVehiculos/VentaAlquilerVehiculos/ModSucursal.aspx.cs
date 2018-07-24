using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio = new Service();
            GridView2.DataSource = servicio.obtenersucursaleshabilitadas();
            GridView2.DataBind();
            Session.Add("idsucursal", "0");
        }

        protected void GridView2_SelectedIndexChanged1(object sender, GridViewSelectEventArgs e)
        {
            Session["idsucursal"] = GridView2.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();
            if((string)(Session["sucursal"])!="0"){
                Server.Transfer("ModInSucursal.aspx");
            }
        }
    }
}