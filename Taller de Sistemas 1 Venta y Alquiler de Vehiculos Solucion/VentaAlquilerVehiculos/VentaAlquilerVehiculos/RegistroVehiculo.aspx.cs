using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class RegistroVehiculo : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                GridView1.DataSource = servicio.obteneridsucdir("CapitanRavelo #2461");
                GridView1.DataBind();
            }
        }

        protected void btnregistro_Click(object sender, EventArgs e)
        {
            double costoventa = Convert.ToDouble(txtcostoventa.Text);
            double costoalquiler = costoventa * 0.02;
            string urlmodelo = txtulrmod.Text;
            string dimensiones = txtdimension.Text+"mm";
            string transmision = ddltrans.SelectedItem.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            string imagen = txturlimg.Text;
            string modelo = txtmodelo.Text;
            string seguridad = "";
            if (CheckBox1.Checked==true)
            {
                seguridad += "-Doble Airbag-";
            }
            if(CheckBox2.Checked==true){
                seguridad += "-Barras Protectoras-";
            }
            if(CheckBox3.Checked==true){
                seguridad += "-Sistema Antirrobo-";
            }
            if(CheckBox4.Checked==true){
                seguridad += "-Seguro Puertas para Niño-";
            }
            string motor = txtmotor.Text + "cc";
            string marca = txtmarca.Text;
            string asientos = ddlasientos.SelectedItem.Text;
            int ciadmin = 9884358;
            int idsucursal = Convert.ToInt32(GridView1.Rows[0].Cells[0].Text.ToString());
            string alquileroventa = ddldisponibilidad.SelectedItem.Text;
            string estado = "Habilitado";

            /*double auxcv = 12.2;
            double auxca = 45.3;
            string auxtexto = "adfgda";
            int auxcant = 5;
            int auxciadmin = 9884358;
            int auxidsuc = 1;*/
            if (cantidad <= Convert.ToInt32(GridView1.Rows[0].Cells[5].Text.ToString()))
            {
                int cantidadvehisucusral = Convert.ToInt32(GridView1.Rows[0].Cells[4].Text.ToString());
                int nuevacantidadvesucursal = cantidadvehisucusral + cantidad;
                Boolean resultado1 = servicio.modificarcantvehicsuc(nuevacantidadvesucursal, idsucursal);
                Boolean resultado2 = servicio.ingresarvehiculo(costoventa, costoalquiler, urlmodelo, dimensiones, transmision, cantidad, imagen, modelo, seguridad, motor, marca, asientos, ciadmin, idsucursal, alquileroventa, estado);
                if (resultado1 == true && resultado2 == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculo Registrado Correctamente')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Vehiculo no registrado')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La cantidad ingresada de Vehiculos sobrepasa el limite de la sucursal seleccionada')", true);
            }
      }

        protected void ddlsuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obteneridsucdir(ddlsuc.SelectedItem.Text);
            GridView1.DataBind();
        }
    }
}