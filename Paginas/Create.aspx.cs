﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajito.Paginas
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Inicio.aspx");
        }
    }
}