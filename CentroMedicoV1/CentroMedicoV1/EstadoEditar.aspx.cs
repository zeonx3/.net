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
    public partial class EstadoEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {
                    int id = Convert.ToInt32(Request["id"].ToString());

                    Estado obj = BussEstado.Buscar(id);
                    if (obj != null)
                    {
                        idestado.Text = obj.Idestado.ToString();
                        descripcion.Text = obj.Descripcion.ToString();

                    }
                    else
                    {
                        Response.Redirect("EstadoListar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("EstadoListar.aspx");
                }
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Estado obj = new Estado();
                obj.Idestado = int.Parse(idestado.Text);
                obj.Descripcion = descripcion.Text;

                BussEstado.update(obj);

                Response.Redirect("EstadoListar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}