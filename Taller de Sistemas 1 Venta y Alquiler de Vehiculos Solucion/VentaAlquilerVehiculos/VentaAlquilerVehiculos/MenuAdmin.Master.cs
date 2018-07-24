using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentaAlquilerVehiculos
{
    public partial class MenuAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = (string)(Session["usuario"]);
            string nick = (string)(Session["nick"]);
            if(usuario !="Administrador"){
                Server.Transfer("Default.aspx");
            }
            Label1.Text = nick;
            Label2.Text = nick;
        }
    }
}