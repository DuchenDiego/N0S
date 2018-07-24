using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace VentaAlquilerVehiculos
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Add("usuario", "Anonimo");
            Session.Add("nick","Desconocido");
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIEGO;Initial Catalog=VentaAlquiler;Integrated Security=True");
            if(ddlusuarios.SelectedItem.Text=="Administrador"){
                SqlCommand cmd = new SqlCommand("SELECT * FROM Administrador WHERE Nick=@Nick and Pass=@Pass",con);
                cmd.Parameters.AddWithValue("@Nick",txtusuario.Text);
                cmd.Parameters.AddWithValue("@Pass",txtcontraseña.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if(dt.Rows.Count>0){
                    Session["usuario"] = "Administrador";
                    Session["nick"] = txtusuario.Text;
                    Server.Transfer("HomeAdmin.aspx");
                }else{
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Datos Incorrectos Intentelo de Nuevo')", true);
                }
            }
            if (ddlusuarios.SelectedItem.Text == "EncargadoAlquiler"){
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM EncargadoAlquiler WHERE UsuarioE=@USE and ContraseñaE=@CE", con);
                cmd2.Parameters.AddWithValue("@USE",txtusuario.Text);
                cmd2.Parameters.AddWithValue("@CE",txtcontraseña.Text);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                con.Open();
                int i = cmd2.ExecuteNonQuery();
                con.Close();
                if(dt2.Rows.Count>0){
                    Session["usuario"] = "EncargadoAlquiler";
                    Session["nick"] = txtusuario.Text;
                    Server.Transfer("HomeAlquiler.aspx");
                }else{
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Datos Incorrectos Intentelo de Nuevo')", true);
                }
            }
            if (ddlusuarios.SelectedItem.Text == "Vendedor"){
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Vendedor WHERE UsuarioV=@USV and ContraV=@CV", con);
                cmd3.Parameters.AddWithValue("@USV", txtusuario.Text);
                cmd3.Parameters.AddWithValue("@CV", txtcontraseña.Text);
                SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                con.Open();
                int i = cmd3.ExecuteNonQuery();
                con.Close();
                if (dt3.Rows.Count > 0){
                    Session["usuario"] = "Vendedor";
                    Session["nick"] = txtusuario.Text;
                    Server.Transfer("HomeVenta.aspx");
                }else{
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Datos Incorrectos Intentelo de Nuevo')", true);
                }
            }
        }

        protected void btnInvitado_Click(object sender, EventArgs e)
        {
            Server.Transfer("HomeInvitado.aspx");
        }


    }
}