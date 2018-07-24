using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class CambiarFotoAlq : System.Web.UI.Page
    {
        Service servicio = new Service();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string nick = (string)(Session["nick"]);
            grdempl.DataSource = servicio.obtenerencargadopornick(nick);
            grdempl.DataBind();
        }

        protected void btncambiar_Click(object sender, EventArgs e)
        {
            if(fileupload1.HasFile){
                //Guardar imagen a la db
                int ciencargado = Convert.ToInt32(grdempl.Rows[0].Cells[2].Text.ToString());
                string nombreimagen = fileupload1.FileName;
                fileupload1.PostedFile.SaveAs(Server.MapPath(".") +"//FotosPerfil//" + nombreimagen);
                string path = "~//FotosPerfil//" + nombreimagen.ToString();
                Boolean resultado = servicio.cambiarimagene(path,ciencargado);
                if (resultado == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Imagen de Perfil Cambiada')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al Cambiar la Imagen')", true);
                }
            }
        }

    }
}