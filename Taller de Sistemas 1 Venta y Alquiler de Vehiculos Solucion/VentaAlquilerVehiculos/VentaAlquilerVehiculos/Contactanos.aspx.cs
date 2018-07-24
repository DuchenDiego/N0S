using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentaAlquilerVehiculos
{
    public partial class Contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmaps_Click(object sender, EventArgs e)
        {
            Server.Transfer("Maps.aspx");
        }
    }
}