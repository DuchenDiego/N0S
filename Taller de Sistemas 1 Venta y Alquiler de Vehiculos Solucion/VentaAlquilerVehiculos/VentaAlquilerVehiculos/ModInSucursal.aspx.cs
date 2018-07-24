using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModInSucursal : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false){
            int idsucursal = Convert.ToInt32(Session["idsucursal"]);
            gvseleccion.DataSource = servicio.obtenersucursalporid(idsucursal);
            gvseleccion.DataBind();
            /*string direccion = gvseleccion.Rows[0].Cells[1].Text.ToString();
            string zona = gvseleccion.Rows[0].Cells[2].Text.ToString();
            string telefono = gvseleccion.Rows[0].Cells[3].Text.ToString();
            int cantvehic = Convert.ToInt32(gvseleccion.Rows[0].Cells[4].Text.ToString());
            int cantmaxvehic = Convert.ToInt32(gvseleccion.Rows[0].Cells[5].Text.ToString());
            gvseleccion.Visible = true;*/
            txtdireccion.Text = gvseleccion.Rows[0].Cells[1].Text.ToString();
            txtzona.Text = gvseleccion.Rows[0].Cells[2].Text.ToString();
            txttelefono.Text = gvseleccion.Rows[0].Cells[3].Text.ToString();
            txtcantidadmaxv.Text = gvseleccion.Rows[0].Cells[5].Text.ToString();
            }
        }

        protected void btnmodificarsuc_Click(object sender, EventArgs e)
        {
            int idsucursal = Convert.ToInt32(Session["idsucursal"]);
            string direccion = txtdireccion.Text;
            string zona = txtzona.Text;
            string telefono = txttelefono.Text;
            int cantvehic = Convert.ToInt32(gvseleccion.Rows[0].Cells[4].Text.ToString());
            int cantmaxvehic = Convert.ToInt32(txtcantidadmaxv.Text);
            int ciadmin = 9884358;
            string estado = "habilitado";
            Boolean resultado = servicio.modifsucursal(direccion, zona, telefono, cantvehic, cantmaxvehic, ciadmin,estado,idsucursal);
            if (resultado == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sucursal Modificada Satisfactoriamente')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sucursal no Modificada, Intentelo de Nuevo')", true);
            }
        }
    }
}