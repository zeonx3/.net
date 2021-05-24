using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class EspecialidadBorrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {
                    int id = Convert.ToInt32(Request["id"].ToString());

                    Especialidad obj = BussEspecialidad.Buscar(id);
                    if (obj != null)
                    {
                        idespecialidad.Text = obj.Idespecialidad.ToString();
                        descripcion.Text = obj.Descripcion.ToString();

                    }
                    else
                    {
                        Response.Redirect("EspecialidadListar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("EspecialidadListar.aspx");
                }
            }


        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idespecialidad.Text);
                BussEspecialidad.delete(id);
                Response.Redirect("EspecialidadListar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}