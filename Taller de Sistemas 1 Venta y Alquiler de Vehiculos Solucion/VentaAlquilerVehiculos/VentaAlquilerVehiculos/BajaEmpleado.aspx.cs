using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class BajaEmpleado : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obtenerempleadoshabilitados();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int ciemp = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.ToString());
            Boolean resultado = servicio.bajaempleado(ciemp);
            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Empleado dada de Baja')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al dar de Baja')", true);
            }
        }
    }
}