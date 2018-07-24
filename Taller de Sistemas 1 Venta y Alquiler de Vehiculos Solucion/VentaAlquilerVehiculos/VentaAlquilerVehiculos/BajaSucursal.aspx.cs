using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class BajaSucursal : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataSource = servicio.obtenersucursaleshabilitadas();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int idsucursal = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.ToString());
            Boolean resultado = servicio.bajasucursal(idsucursal);
            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sucursal dada de Baja')", true);
            }else{
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al dar de Baja')", true);
            }
        }

    }
}