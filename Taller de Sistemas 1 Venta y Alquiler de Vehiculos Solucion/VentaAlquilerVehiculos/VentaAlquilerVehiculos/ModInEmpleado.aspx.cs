using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModInEmpleado : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int ciempleado = Convert.ToInt32(Session["ciempleado"]);
                GridView2.DataSource = servicio.obtenerempleadoporid(ciempleado);
                GridView2.DataBind();
                txtciempl.Text = GridView2.Rows[0].Cells[0].Text.ToString();
                txtnombreempl.Text = GridView2.Rows[0].Cells[1].Text.ToString();
                txtapp.Text = GridView2.Rows[0].Cells[2].Text.ToString();
                txtapm.Text = GridView2.Rows[0].Cells[3].Text.ToString();
                txtFecha.Text = GridView2.Rows[0].Cells[4].Text.ToString();
                txtemail.Text = GridView2.Rows[0].Cells[5].Text.ToString();
                txtcel.Text = GridView2.Rows[0].Cells[6].Text.ToString();
                txtlat.Text = GridView2.Rows[0].Cells[8].Text.ToString();
            }
            
        }


        protected void btnmodificar_Click(object sender, EventArgs e)
        {
          int ciempleado =Convert.ToInt32(txtciempl.Text);
          string nombre = txtnombreempl.Text;
          string apellidop = txtapp.Text;
          string apellidom = txtapm.Text;
          string nick = txtnick.Text;
          string pass = txtpass.Text;
          string pass2 = txtconfpass.Text;
          string fechanac = txtFecha.Text;
          string email = txtemail.Text;
          string celular = txtcel.Text;
          string estado= "Habilitado";
          string latencia = txtlat.Text;
          int ciadmin = 9884358;
          int idsuc = Convert.ToInt32(GridView1.Rows[0].Cells[0].Text.ToString());
          string img = "";
          string ocupacion = GridView2.Rows[0].Cells[9].Text.ToString();
          if(pass==pass2){
              if(ocupacion=="EncargadoAlquiler"){
                  Boolean resultado = servicio.modifempleado(ciempleado,nombre,apellidop,apellidom,fechanac,email,celular,estado,latencia,ocupacion,ciadmin,idsuc,ciempleado);
                  Boolean resultado2 = servicio.modificarencargado(nick, pass, ciempleado, img,ciempleado);
                  if(resultado==true && resultado2==true){
                      ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Encargado de Alquiler Modificado')", true);
                      }else{
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Encargado no Modificado')", true);
                      }
              }
              else if (ocupacion == "Vendedor")
              {
                      Boolean resultado3 = servicio.modifempleado(ciempleado, nombre, apellidop, apellidom, fechanac, email, celular, estado, latencia, ocupacion, ciadmin, idsuc,ciempleado);
                      Boolean resultado4 = servicio.modificarvendedor(nick, pass, ciempleado, img,ciempleado);
                      if (resultado3 == true && resultado4 == true)
                      {
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vendedor Modificado')", true);
                      }
                      else
                      {
                          ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Vendedor no Modificado')", true);
                      }
                  }
          }else{
                  ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Contraseñas Diferentes')", true);
          }
        }

        protected void ddlsucursals_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obteneridsucdir(ddlsucursals.SelectedItem.Text);
            GridView1.DataBind();
        }

    }
}