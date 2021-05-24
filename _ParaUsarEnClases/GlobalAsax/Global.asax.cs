using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace GlobalAsax
{
    public class Global : System.Web.HttpApplication
    {
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = "";
            Session["usuario"] = "";
            Session["email"] = "";
            Session["fechahoy"] = DateTime.Today.ToString("dd/MM/yyyy");

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["login"] = "";
            Session["usuario"] = "";
            Session["email"] = "";
            Session["fechahoy"] = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}