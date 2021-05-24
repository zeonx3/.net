﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = "";
            Session["usuario"] = "";
            Session["email"] = "";
            Session["fechahoy"] = DateTime.Today.ToString("dd/MM/yyyy");
            Response.Redirect("index.aspx");
        }
    }
}