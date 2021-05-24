using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            lblMsg.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioModel obj = new UsuarioModel();
            obj.Usuario = txtUsuario.Text;
            obj.Clave = txtClave.Text;
            DataTable dt = BussUsuario.Validar(obj);
            if (dt != null && dt.Rows.Count > 0)
            {
                Session["login"] = "N3T4CC3SS";
                Session["usuario"] = dt.Rows[0]["usuario"].ToString();
                Session["email"] = dt.Rows[0]["email"].ToString();
                Response.Redirect("Menu.aspx");
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Error, usuario o clave incorrecta!";
            }

        }
    }
}