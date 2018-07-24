using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class HomeInvitado : System.Web.UI.Page
    {
        Service servicio=new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obtenervehiculoss();
            GridView1.DataBind();
            Session.Add("idvehicinvselec", "0");
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["idvehicinvselec"] = GridView1.Rows[e.NewSelectedIndex].Cells[6].Text.ToString();
            if ((string)(Session["idvehicinvselec"]) != "0")
            {
                Server.Transfer("DetalleVehicInv.aspx");
            }
        }
    }
}