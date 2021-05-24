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
    public partial class EspecialidadNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad obj = new Especialidad();
                obj.Idespecialidad = 0;
                obj.Descripcion = descripcion.Text;
                
                BussEspecialidad.Insert(obj);

                Response.Redirect("EspecialidadListar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}