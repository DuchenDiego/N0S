<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VentaAlquilerVehiculos._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>N2O</title>
<link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet"> 
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
<style>
    @charset "utf-8";
@import url(http://weloveiconfonts.com/api/?family=fontawesome);

[class*="fontawesome-"]:before {
  font-family: 'FontAwesome', sans-serif;
}

body {
  background:url(../Imagenes/wallup.jpg) ;
  background-size: cover;
  color: #606468;
  font: 87.5%/1.5em 'Open Sans', sans-serif;
  margin: 0;
}

input {
  border: none;
  font-family: 'Open Sans', Arial, sans-serif;
  font-size: 16px;
  line-height: 1.5em;
  padding: 0;
  -webkit-appearance: none;
}

p {
  line-height: 1.5em;
}

after { clear: both; }

#login {
  margin: 50px auto;
  width: 320px;
  margin-top:10%;
}

#login form {
  margin: auto;
  padding: 22px 22px 22px 22px;
  width: 100%;
  border-radius: 5px;
  background: #282e33;
  border-top: 3px solid #434a52;
  border-bottom: 3px solid #434a52;
  /*margin-top:60px;*/
}

#login form span {
  background-color: #363b41;
  border-radius: 3px 0px 0px 3px;
  border-right: 3px solid #434a52;
  color: #606468;
  display: block;
  float: left;
  line-height: 50px;
  text-align: center;
  width: 50px;
  height: 50px;
}

.texto{
  background-color: #3b4148;
  border-radius: 0px 3px 3px 0px;
  color: #a9a9a9;
  margin-bottom: 1em;
  padding: 0 16px;
  width: 235px;
  height: 50px;
}


.boton{
  background: #622C32;
  border: 0;
  width: 100%;
  height: 40px;
  border-radius: 3px;
  color: white;
  cursor: pointer;
  transition: background 0.3s ease-in-out;
}
.boton:hover {
  background: #76384A;
}

.boton1{
  background: #122B2F;
  border: 0;
  width: 100%;
  height: 40px;
  border-radius: 3px;
  color: white;
  cursor: pointer;
  transition: background 0.3s ease-in-out;
}
.boton1:hover {
  background: #2C4049;
}
.title {
    font-family: 'Kaushan Script', cursive;
    font-size:x-large;
    color:white;
    width: 100%;
    height: 60px;
    margin-left:20%;
}
.big {
  font-size: 1.2em;
}

.small {
  font-size: .7em;
}

.square {
  width: .7em;
  height: .7em;
  margin: .5em;
  display: inline-block;
}

/* Custom dropdown */
.custom-dropdown {
  position: relative;
  display: inline-block;
  vertical-align: middle;
  margin: 2px; /* demo only */
}

.custom-dropdown select {
  background-color: #949CA6;
  color: #fff;
  font-size: inherit;
  padding: .5em;
  padding-right: 2.5em;	
  border: 0;
  margin: 0;
  border-radius: 3px;
  text-indent: 0.01px;
  text-overflow: '';
  -webkit-appearance: button; /* hide default arrow in chrome OSX */
  width:230px;
  height:48px;
}

.custom-dropdown::before,
.custom-dropdown::after {
  content: "";
  position: absolute;
  pointer-events: none;
}

.custom-dropdown::after { /*  Custom dropdown arrow */
  content: "\25BC";
  height: 1em;
  font-size: .625em;
  line-height: 1;
  right: 1.2em;
  top: 50%;
  margin-top: -.5em;
}

.custom-dropdown::before { /*  Custom dropdown arrow cover */
  width: 2em;
  right: 0;
  top: 0;
  bottom: 0;
  border-radius: 0 3px 3px 0;
}
.custom-dropdown::before {
  background-color: rgba(0,0,0,.15);
}

.custom-dropdown::after {
  color: rgba(0,0,0,.4);
}

/*Efecto Css Crossed In*/

/*...................*/
</style>
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:400,700">
</head>
<body class="loading">
    <div class="animated flash">
    <div id="login">
         <asp:Label ID="Label1" runat="server" CssClass="title" Text="Venta y Alquiler N2O"></asp:Label>
        <form id="form1" runat="server">
            <asp:TextBox ID="txtusuario" CssClass="texto" runat="server"  onclick="txtusuarioclick"></asp:TextBox>
            <span class="fontawesome-user"></span>
           
             <asp:TextBox ID="txtcontraseña" CssClass="texto" TextMode="Password" runat="server" onclick="txtcontraclick"></asp:TextBox>
             <span class="fontawesome-lock"></span>
           
            <asp:Label ID="Label3" runat="server" CssClass="texto" Text="Tipo"></asp:Label>
            <div class="custom-dropdown big">
                <asp:DropDownList ID="ddlusuarios"  runat="server">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>EncargadoAlquiler</asp:ListItem>
                <asp:ListItem>Vendedor</asp:ListItem>
                </asp:DropDownList>
            </div>
          <!--<div class="custom-dropdown select">
                <select id="ddlusuarios">
                <option value="Masculino">Masculino</option>
                <option value="Femenino">Femenino</option>
                </select>
            </div>-->

            <asp:Button ID="btnlogin" CssClass="boton" runat="server" Text="Login" OnClick="btnlogin_Click"  />
            <br><br>
            <asp:Button ID="btnInvitado" CssClass="boton1" runat="server" Text="Invitado" OnClick="btnInvitado_Click"  />
        </form>
    </div>
   </div>
</body>
<!--Script Efecto fade in-->

</html>
