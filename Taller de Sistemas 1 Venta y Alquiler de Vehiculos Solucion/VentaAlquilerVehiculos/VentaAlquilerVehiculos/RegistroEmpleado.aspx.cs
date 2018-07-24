using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class RegistroEmpleado : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false){
                GridView1.DataSource = servicio.obteneridsucdir("CapitanRavelo #2461");
                GridView1.DataBind();
                //GridView1.Visible = true;
            }
        }
        protected void btnregistro_Click(object sender, EventArgs e)
        {
          
          int ciempleado =Convert.ToInt32(txtciempl.Text);
          string nombre = txtnombreempl.Text;
          string apellidop = txtapp.Text;
          string apellidom = txtapm.Text;
          string nick = txtnick.Text;
          string pass = txtpass.Text;
          string pass2 = txtconfpass.Text;
          DateTime fechanac = Convert.ToDateTime(txtFecha.Text);
          string email = txtemail.Text;
          string celular = txtcel.Text;
          string estado= "Habilitado";
          string latencia = txtlat.Text;
          string ocupacion = ddlocupacion.SelectedItem.Text;
          int ciadmin = 9884358;
          int idsuc = Convert.ToInt32(GridView1.Rows[0].Cells[0].Text.ToString());
          string img="";
          if(pass==pass2){
              if(ddlocupacion.SelectedItem.Text=="EncargadoAlquiler"){
                  Boolean resultado = servicio.ingresarempleado(ciempleado,nombre,apellidop,apellidom,fechanac,email,celular,estado,latencia,ocupacion,ciadmin,idsuc);
                  Boolean resultado2 = servicio.ingresarencargado(nick, pass, ciempleado, img);
                  if(resultado==true && resultado2==true){
                      ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Encargado de Alquiler Registrado')", true);
                      }else{
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Encargado no Registrado')", true);
                      }
                  }else if(ddlocupacion.SelectedItem.Text=="Vendedor"){
                      Boolean resultado3 = servicio.ingresarempleado(ciempleado, nombre, apellidop, apellidom, fechanac, email, celular, estado, latencia, ocupacion, ciadmin, idsuc);
                      Boolean resultado4 = servicio.ingresarvendedor(nick, pass, ciempleado,img);
                      if (resultado3 == true && resultado4 == true)
                      {
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vendedor Registrado')", true);
                      }
                      else
                      {
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Vendedor no Registrado')", true);
                      }
                  }
          }else{
              ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Contraseñas Diferentes')", true);
          }
        }

        protected void ddlsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obteneridsucdir(ddlsucursal.SelectedItem.Text);
            GridView1.DataBind();
        }
    }
}