using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio = new Service();
            GridView1.DataSource = servicio.obtenerempleadoshabilitados();
            GridView1.DataBind();
            Session.Add("ciempleado", "0");
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Session["ciempleado"] = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();
            if ((string)(Session["ciempleado"]) != "0")
            {
                Server.Transfer("ModInEmpleado.aspx");
            }
        }
    }
}