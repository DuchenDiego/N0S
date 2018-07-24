using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos.Modulo_Alquiler
{
    public partial class MenuAlquiler : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service servicio= new Service();
            string usuario = (string)(Session["usuario"]);
            string nick = (string)(Session["nick"]);
            if (usuario != "EncargadoAlquiler")
            {
                Server.Transfer("Default.aspx");
            }
            Label1.Text = nick;
            Label2.Text = nick;
            GridView1.DataSource = servicio.obtenerencargadopornick(nick);
            GridView1.DataBind();
            Image1.ImageUrl = GridView1.Rows[0].Cells[3].Text.ToString();
        }
    }
}