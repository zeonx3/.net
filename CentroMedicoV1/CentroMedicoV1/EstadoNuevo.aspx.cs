using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class EstadoNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Estado obj = new Estado();
                obj.Idestado = 0;
                obj.Descripcion = descripcion.Text;

                BussEstado.Insert(obj);

                Response.Redirect("EstadoListar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
    }
