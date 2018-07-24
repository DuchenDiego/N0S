using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class ModInVehiculo : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            
             if(Page.IsPostBack==false){
            int idvehiculo = Convert.ToInt32(Session["idvehiculo"]);
            grdvehicselec.DataSource = servicio.obtenervehiculoporid(idvehiculo);
            grdvehicselec.DataBind();
            //txtmarca.Text = GridView1.Rows[0].Cells[11].Text.ToString();
            //txtmodelo.Text = GridView1.Rows[0].Cells[8].Text.ToString();
            //txturlimg.Text = GridView1.Rows[0].Cells[7].Text.ToString();
           // txtulrmod.Text = GridView1.Rows[0].Cells[3].Text.ToString();
           // txtcostoventa.Text = GridView1.Rows[0].Cells[1].Text.ToString();
           // txtdimension.Text = GridView1.Rows[0].Cells[4].Text.ToString();
            //txtmotor.Text = GridView1.Rows[0].Cells[10].Text.ToString();
           /* TextBox1.Text = 
            TextBox2.Text = grdvehicselec.Rows[0].Cells[1].Text.ToString();
            TextBox3.Text = grdvehicselec.Rows[0].Cells[2].Text.ToString();
            TextBox4.Text = grdvehicselec.Rows[0].Cells[3].Text.ToString();
            TextBox5.Text = grdvehicselec.Rows[0].Cells[4].Text.ToString();*/
            }
        }

    }
}