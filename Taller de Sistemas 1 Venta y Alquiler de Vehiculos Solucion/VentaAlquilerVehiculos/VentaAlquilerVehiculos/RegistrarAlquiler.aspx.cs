using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
namespace VentaAlquilerVehiculos
{
    public partial class RegistrarAlquiler : System.Web.UI.Page
    {
        public List<String> FechasDefinitivas = new List<String>();
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdvehiculos.DataSource = servicio.obtenervehiculosalquilerhabilitados();
            grdvehiculos.DataBind();
            string nick = (string)(Session["nick"]);
            grdauxempleado.DataSource = servicio.obtenerencargadopornick(nick);
            grdauxempleado.DataBind();
        }
        protected void btngenerarvista_Click(object sender, EventArgs e)
        {
            
            List<DateTime> Fechas = new List<DateTime>();
            DateTime inicio = DateTime.Parse(txtfechainicio.Text);
            DateTime final = DateTime.Parse(txtfechafinal.Text);
            int finalint = Convert.ToInt32(final.Day.ToString());
            int inicioint = Convert.ToInt32(inicio.Day.ToString());
           
            for (DateTime i = inicio; i <=final; i = i.AddDays(1))
            {
                Fechas.Add(i);
            }
            
            foreach (DateTime Fecha in Fechas){
                string dia = Fecha.Day.ToString();
                string mes = Fecha.Month.ToString();
                string año = Fecha.Year.ToString();
                string fechaformateada = año + "," + mes + "," + dia;
                FechasDefinitivas.Add(fechaformateada);
            }
       
        }

        protected void btnbuscarci_Click(object sender, EventArgs e)
        {
            if (txtcic.Text != string.Empty)
            {
                int cicl = Convert.ToInt32(txtcic.Text);
                grdauxcliente.DataSource = servicio.obtenerclienteporid(cicl);
                grdauxcliente.DataBind();
                if (grdauxcliente.Rows.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente No Encontrado, Registre al nuevo cliente')", true);


                }
                else
                {
                    txtci.Text = grdauxcliente.Rows[0].Cells[0].Text.ToString();
                    txtnombre.Text = grdauxcliente.Rows[0].Cells[1].Text.ToString();
                    txtapp.Text = grdauxcliente.Rows[0].Cells[2].Text.ToString();
                    txtapm.Text = grdauxcliente.Rows[0].Cells[3].Text.ToString();
                    txtcel.Text = grdauxcliente.Rows[0].Cells[4].Text.ToString();
                    txtemail.Text = grdauxcliente.Rows[0].Cells[5].Text.ToString();
                    txtdireccion.Text = grdauxcliente.Rows[0].Cells[6].Text.ToString();
                    txtnumbanc.Text = grdauxcliente.Rows[0].Cells[7].Text.ToString();
                    RequiredFieldValidator3.Visible = false;
                    RequiredFieldValidator4.Visible = false;
                    RequiredFieldValidator5.Visible = false;
                    RequiredFieldValidator6.Visible = false;
                    RequiredFieldValidator7.Visible = false;
                    RequiredFieldValidator8.Visible = false;
                    RequiredFieldValidator9.Visible = false;
                    RequiredFieldValidator10.Visible = false;
                    txtci.ReadOnly = true;
                    txtnombre.ReadOnly = true;
                    txtapp.ReadOnly = true;
                    txtapm.ReadOnly = true;
                    txtcel.ReadOnly = true;
                    txtemail.ReadOnly = true;
                    txtdireccion.ReadOnly = true;
                    txtnumbanc.ReadOnly = true;
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente Encontrado')", true);

                }
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ingrese un CI de un cliente')", true);
            }
        }

        protected void grdvehiculos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string idvehic = grdvehiculos.Rows[e.NewSelectedIndex].Cells[6].Text.ToString();
            Session.Add("idvehic",idvehic);
            int preciosem = Convert.ToInt32(grdvehiculos.Rows[e.NewSelectedIndex].Cells[4].Text.ToString());
            Session.Add("preciosemanal", preciosem);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculo Seleccionado')", true);
            grdauxvehiculo.DataSource = servicio.obtenervehiculoporid(Convert.ToInt32(idvehic));
            grdauxvehiculo.DataBind();
        }

        protected void btnpreparareserva_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////
            /*DateTime fechainicial = Convert.ToDateTime(txtfechainicio.Text);
            DateTime fechafinal = Convert.ToDateTime(txtfechafinal.Text);
            DateTime fechaalquiler = System.DateTime.Today;
            TimeSpan ts = fechafinal - fechainicial;
            int plazo = ts.Days;
            int preciosemanal = Convert.ToInt32(Session["preciosemanal"]);
            int totalapagar = (preciosemanal / 5) * (plazo + 1);
            int idvehiculo = Convert.ToInt32(Session["idvehic"]);
            int cicliente = Convert.ToInt32(txtci.Text);
            int ciempleado = Convert.ToInt32(grdauxempleado.Rows[0].Cells[2].Text.ToString());
            string estado = "Pendiente";
            string nombre = txtnombre.Text;
            string apellidop = txtapp.Text;
            string apellidom = txtapm.Text;
            string celular = txtcel.Text;
            string email = txtemail.Text;
            string direccion = txtdireccion.Text;
            string numbanc = txtnumbanc.Text;*/
            //////////////////////////////////////////////////////////////////////////////////
            if (txtfechainicio.Text!=string.Empty && txtfechafinal.Text!=string.Empty)
            {
                ////
                DateTime fechainicial = Convert.ToDateTime(txtfechainicio.Text);
                DateTime fechafinal = Convert.ToDateTime(txtfechafinal.Text);
                DateTime fechaalquiler = System.DateTime.Today;
                TimeSpan ts = fechafinal - fechainicial;
                int plazo = ts.Days;
                int preciosemanal = Convert.ToInt32(Session["preciosemanal"]);
                int totalapagar = (preciosemanal / 5) * (plazo + 1);
                ////
                if (grdauxvehiculo.Rows.Count != 0)
                {
                    ////
                    int idvehiculo = Convert.ToInt32(Session["idvehic"]);
                    ////
                    if (txtci.Text != string.Empty && txtnombre.Text != string.Empty && txtapp.Text != string.Empty && txtapm.Text != string.Empty && txtcel.Text != string.Empty && txtemail.Text != string.Empty && txtdireccion.Text != string.Empty && txtnumbanc.Text != string.Empty)
                    {
                        int cicliente = Convert.ToInt32(txtci.Text);
                        int ciempleado = Convert.ToInt32(grdauxempleado.Rows[0].Cells[2].Text.ToString());
                        string estado = "Pendiente";
                        string nombre = txtnombre.Text;
                        string apellidop = txtapp.Text;
                        string apellidom = txtapm.Text;
                        string celular = txtcel.Text;
                        string email = txtemail.Text;
                        string direccion = txtdireccion.Text;
                        string numbanc = txtnumbanc.Text;
                        if (grdauxcliente.Rows.Count == 0)
                        {
                            ////
  
                            ////
                            ///ingresar texto no vacio
                            grdauxauxcliente.DataSource = servicio.obtenerclienteporid(cicliente);
                            grdauxauxcliente.DataBind();
                            if(grdauxauxcliente.Rows.Count==0)
                            {
                              //  Response.Write("cliente inexistente");
                                Boolean resultado = servicio.ingresarcliente(cicliente, nombre, apellidop, apellidom, celular, email, direccion, numbanc);
                                if (resultado == true)
                                {
                                    Boolean resultado2 = servicio.ingresaralquiler(fechainicial, fechafinal, fechaalquiler, totalapagar, plazo + 1, ciempleado, cicliente, idvehiculo, estado);
                                    Boolean resultado3 = servicio.disminucionvehiculoalquiler(idvehiculo);
                                    if (resultado2 == true && resultado3==true)
                                    {
                                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente Registrado y Alquiler Realizado')", true);
                                    }
                                    else
                                    {
                                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al registrar cliente y alquiler')", true);
                                    }
                                }
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente ya registrado en el sistema con el mismo CI')", true);
                            }
                        }
                        else
                        {
                            ////
                          /*  int cicliente = Convert.ToInt32(txtci.Text);
                            int ciempleado = Convert.ToInt32(grdauxempleado.Rows[0].Cells[2].Text.ToString());
                            string estado = "Pendiente";
                            string nombre = txtnombre.Text;
                            string apellidop = txtapp.Text;
                            string apellidom = txtapm.Text;
                            string celular = txtcel.Text;
                            string email = txtemail.Text;
                            string direccion = txtdireccion.Text;
                            string numbanc = txtnumbanc.Text;*/
                            ////
                            ///ingresar texto no vacio
                            grdauxalquiler.DataSource = servicio.obteneralquilerporcicliente(cicliente);
                            grdauxalquiler.DataBind();
                            if(grdauxalquiler.Rows.Count!=0)
                            {
                                if (grdauxalquiler.Rows[0].Cells[8].Text.ToString() != "Pendiente")
                                {
                                    Boolean resultado4 = servicio.ingresaralquiler(fechainicial, fechafinal, fechaalquiler, totalapagar, plazo + 1, ciempleado, cicliente, idvehiculo, estado);
                                    Boolean resultado5 = servicio.disminucionvehiculoalquiler(idvehiculo);
                                    if (resultado4 == true && resultado5==true)
                                    {
                                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Alquiler Realizado')", true);
                                    }
                                    else
                                    {
                                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al registrar alquiler')", true);
                                    }
                                }
                                else
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('El Cliente ingresado ya tiene un alquiler pendiente')", true);
                                }
                            }
                            else
                            {
                                Boolean resultado6 = servicio.ingresaralquiler(fechainicial, fechafinal, fechaalquiler, totalapagar, plazo + 1, ciempleado, cicliente, idvehiculo, estado);
                                Boolean resultado7 = servicio.disminucionvehiculoalquiler(idvehiculo);
                                if (resultado6 == true && resultado7==true)
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Alquiler Realizado')", true);
                                }
                                else
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al registrar alquiler')", true);
                                }
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe llenar todos los campos del cliente')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe Escoger un vehiculo para alquilar')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe llenar las fechas de inicio y final del alquiler')", true);
            }
           
        }

    }
}