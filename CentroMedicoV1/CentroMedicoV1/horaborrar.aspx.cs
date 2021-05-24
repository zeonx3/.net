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
    public partial class horaborrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {
                    int id = Convert.ToInt32(Request["id"].ToString());

                    Hora obj = BussHora.Buscar(id);
                    if (obj != null)
                    {
                        idhora.Text = obj.Idhora.ToString();
                        fecha.Text = obj.FechaTxt.ToString();
                        horaminuto.Text = obj.HoraminutoTxt.ToString();
                        medico.Text = obj.Medico.NomMedico.ToString();
                        estado.Text = obj.Estado.Descripcion.ToString();
                    }
                    else
                    {
                        Response.Redirect("horalistar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("horalistar.aspx");
                }
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idhora.Text);
                BussHora.Delete(id);
                Response.Redirect("horalistar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}