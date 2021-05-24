using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnespecialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("EspecialidadListar.aspx");
        }

        protected void btnestado_Click(object sender, EventArgs e)
        {
            Response.Redirect("EstadoListar.aspx");
        }

        protected void btnmedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("medicolistar.aspx");
        }

        protected void btnhora_Click(object sender, EventArgs e)
        {
            Response.Redirect("horalistar.aspx");
        }

        protected void btnreserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservalistar.aspx");
        }
    }
}