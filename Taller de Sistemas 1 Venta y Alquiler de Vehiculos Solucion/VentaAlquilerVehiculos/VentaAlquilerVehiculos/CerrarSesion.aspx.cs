﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VentaAlquilerVehiculos
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Session.Remove("nick");
            Server.Transfer("Default.aspx");
        }
    }
}