using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio = new Service();
            GridView2.DataSource = servicio.obtenerempleados();
            GridView2.DataBind();
            GridView3.DataSource = servicio.obtenervehiculoss();
            GridView3.DataBind();
            GridView1.DataSource = servicio.obtenersucursales();
            GridView1.DataBind();
        }
    }
}