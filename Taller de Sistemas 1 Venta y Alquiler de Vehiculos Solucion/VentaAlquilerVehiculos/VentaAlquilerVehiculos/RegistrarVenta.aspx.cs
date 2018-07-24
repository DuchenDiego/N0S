using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VentaAlquilerVehiculos.RefserviciowebVentaAlquiler;
using ControlCodeV7;
namespace VentaAlquilerVehiculos
{
    public partial class RegistrarVenta : System.Web.UI.Page
    {
        Service servicio = new Service();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdvehiculos.DataSource = servicio.obtenervehiculosventahabilitados();
            grdvehiculos.DataBind();
            string nick = (string)(Session["nick"]);
            grdauxempleado.DataSource = servicio.obtenervendedorpornick(nick);
            grdauxempleado.DataBind();
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
            Session.Add("idvehic", idvehic);
            string precioventa = grdvehiculos.Rows[e.NewSelectedIndex].Cells[4].Text.ToString();
            Session.Add("precioventa", precioventa);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculo Seleccionado')", true);
            grdauxvehiculo.DataSource = servicio.obtenervehiculoporid(Convert.ToInt32(idvehic));
            grdauxvehiculo.DataBind();
        }

        protected void btnregistrarventa_Click(object sender, EventArgs e)
        {
            if (grdauxvehiculo.Rows.Count != 0)
            {
                int idvehiculo = Convert.ToInt32(Session["idvehic"]);
                int idsucvehic = Convert.ToInt32(grdauxvehiculo.Rows[0].Cells[14].Text.ToString());
                if (txtci.Text != string.Empty && txtnombre.Text != string.Empty && txtapp.Text != string.Empty && txtapm.Text != string.Empty && txtcel.Text != string.Empty && txtemail.Text != string.Empty && txtdireccion.Text != string.Empty && txtnumbanc.Text != string.Empty)
                {
                    int cicliente = Convert.ToInt32(txtci.Text);
                    int ciempleado = Convert.ToInt32(grdauxempleado.Rows[0].Cells[2].Text.ToString());
                    string nombre = txtnombre.Text;
                    string apellidop = txtapp.Text;
                    string apellidom = txtapm.Text;
                    string celular = txtcel.Text;
                    string email = txtemail.Text;
                    string direccion = txtdireccion.Text;
                    string numbanc = txtnumbanc.Text;
                    DateTime fechaactual = DateTime.Today;
                    if (grdauxcliente.Rows.Count == 0)
                    {
                        grdauxauxcliente.DataSource = servicio.obtenerclienteporid(cicliente);
                        grdauxauxcliente.DataBind();
                        if (grdauxauxcliente.Rows.Count == 0)
                        {

                            Boolean resultado = servicio.ingresarcliente(cicliente, nombre, apellidop, apellidom, celular, email, direccion, numbanc);
                            if (resultado == true)
                            {
                                Boolean resultado2 = servicio.ingresarventa(ciempleado,idvehiculo,cicliente,fechaactual);
                                Boolean resultado3 = servicio.disminucionvehiculoventa(idvehiculo);
                                Boolean resultado4 = servicio.disminucionvehiculosuc(idsucvehic);
                                if (resultado2 == true && resultado3==true && resultado4==true)
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente Registrado y Venta Realizada')", true);
                                    btngenerarfactura.Visible = true;
                                }
                                else
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al registrar cliente y venta')", true);
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
                        Boolean resultado5 = servicio.ingresarventa(ciempleado, idvehiculo, cicliente, fechaactual);
                        Boolean resultado6 = servicio.disminucionvehiculoventa(idvehiculo);
                        Boolean resultado7 = servicio.disminucionvehiculosuc(idsucvehic);
                        if (resultado5 == true && resultado6 == true && resultado7==true)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Venta Realizada Satisfactoriamente')", true);
                            btngenerarfactura.Visible = true;
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al registrar venta')", true);
                        }
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe llenar todos los campos de los datos del cliente')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un Vehiculo para la Venta')", true);
            }
        }

        protected void btngenerarfactura_Click(object sender, EventArgs e)
        {
            string cicliente = txtci.Text;
            string numeroautorizacion = "7904001278544";
            string nitempresa = "1026469026";
            double precioventausd = Convert.ToDouble(Session["precioventa"]);
            double preciobs = precioventausd * 6.96;
            DateTime fechaactual = DateTime.Today;
            string dia = fechaactual.Day.ToString();
            string mes = fechaactual.Month.ToString();
            string año = fechaactual.Year.ToString();
            string fechaactualformateada = año + mes + dia;
            string llavedosificacion = "9rCB7Sv4X29d)5k7N%3ab89p-3(5[A";
            grdauxventa.DataSource=servicio.obtenerventaporcicliente(Convert.ToInt32(cicliente));
            grdauxventa.DataBind();
            string numerofactura=grdauxventa.Rows[0].Cells[0].Text.ToString();
            string ciempl = grdauxempleado.Rows[0].Cells[2].Text.ToString();
            String codigocontrol = ControlCode.generateControlCode(numeroautorizacion,numerofactura,cicliente,fechaactualformateada,Convert.ToString(preciobs),llavedosificacion);
            Boolean resultado8 = servicio.registrarfactura(Convert.ToInt32(numerofactura), cicliente, nitempresa, numeroautorizacion, preciobs, codigocontrol, Convert.ToInt32(ciempl));
            if (resultado8 == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Factura Generada')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al generar la factura')", true);
            }
            btngenerarfactura.Visible = false;
        }

    }
}