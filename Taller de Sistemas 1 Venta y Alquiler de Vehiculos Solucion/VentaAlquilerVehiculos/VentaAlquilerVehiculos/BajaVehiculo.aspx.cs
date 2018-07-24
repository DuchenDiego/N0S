using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class BajaVehiculo : System.Web.UI.Page
    {
        Service servicio = new Service();
        int idsucursalselec = 0;
        int idvehicselec = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.obtenervehiculoshabilitados();
            GridView1.DataBind();
          //  grdauxsucursal.Visible = true;
            /*Session.Add("idvehicselec", 0);
            Session.Add("idsucursal",0);
            Label2.Text = Convert.ToString(Session["idsucursal"]);
            Label3.Text = Convert.ToString(Session["idvehicselec"]);
            Label2.Text = Convert.ToString(idsucursalselec);
            Label3.Text = Convert.ToString(idvehicselec);*/
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculo Seleccionado')", true);
           //Session["idsucursal"] = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[11].Text.ToString());
            idsucursalselec = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[11].Text.ToString());
            idvehicselec = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[12].Text.ToString());
            grdauxsucursal.DataSource = servicio.obtenersucursalporid(idsucursalselec);
            grdauxsucursal.DataBind();
            txtcantveselec.Text = GridView1.Rows[e.NewSelectedIndex].Cells[7].Text.ToString();
            Session.Add("idsucursal", idsucursalselec);
            Session.Add("idvehicselec", idvehicselec);
        }

        protected void btnbaja_Click(object sender, EventArgs e)
        {
            int idsucursalselecaux = Convert.ToInt32(Session["idsucursal"]);
            int idvehicselecaux = Convert.ToInt32(Session["idvehicselec"]);
            int cantidadadarbaja=Convert.ToInt32(txtcantbaja.Text);
            int cantidadvehicdisp=Convert.ToInt32(txtcantveselec.Text);
            int cantidadvehicdispsuc=Convert.ToInt32(grdauxsucursal.Rows[0].Cells[4].Text.ToString());
            if (cantidadadarbaja <= cantidadvehicdisp)
            {
                int nuevacantidadvehic = cantidadvehicdisp - cantidadadarbaja;
                int nuevacantidadvehisuc=cantidadvehicdispsuc-cantidadadarbaja;
             //   int idvehiculo = Convert.ToInt32((Session["idvehicselec"]));
                Boolean resultado1 = servicio.modificarcantidadvehiculos(nuevacantidadvehic, idvehicselecaux);
                Boolean resultado2 = servicio.modificarcantvehicsuc(nuevacantidadvehisuc, idsucursalselecaux);
                if (resultado1 == true && resultado2 == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculos dados de Baja')", true);
                    
                }
                else {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error la cantidad no se dio de baja')", true);
                }

                if(nuevacantidadvehic==0){
                    Boolean resultado3 = servicio.bajavehiculo(idvehicselecaux);
                   
                }
            }
            else {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La cantidad que se debe ingresar no debe sobrepasar la cantidad existente')", true);
            }
        }
    }
}