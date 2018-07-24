using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;

namespace VentaAlquilerVehiculos
{
    public partial class RegistroSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregistrosuc_Click(object sender, EventArgs e)
        {
            
            string direccion = txtdireccion.Text;
            string zona = txtzona.Text;
            string telefono = txttelf.Text;
            int cantvehiculos = 0;
            int cantmaxvehiculos =Convert.ToInt32(txtcantmax.Text);
            int ciadmin = 9884358;
            string estado = "Habilitado";
            Service servicio = new Service();
            Boolean resultado = servicio.ingresarsucursal(direccion,zona,telefono,cantvehiculos,cantmaxvehiculos,ciadmin,estado);
            if(resultado==true){
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sucursal Registrada Satisfactoriamente')", true);
                }else{
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sucursal no Registrada, Intentelo de Nuevo')", true);
                }
        }
    }
}