using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class HomeVenta : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio = new Service();
            GridView1.DataSource = servicio.obtenervehiculosventahabilitados();
            GridView1.DataBind();
        }
    }
}