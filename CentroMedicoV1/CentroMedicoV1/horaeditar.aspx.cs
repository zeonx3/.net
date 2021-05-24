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
    public partial class horaeditar : System.Web.UI.Page
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
                    // llenar los DropDownList
                    DataTable dtm = BussMedico.Listar();
                    idmedico.Items.Add(new ListItem("Seleccione..", ""));
                    foreach (DataRow r in dtm.Rows)
                    {
                        string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                        string valor = r["idmedico"].ToString();
                        idmedico.Items.Add(new ListItem(texto, valor));
                    }

                    DataTable dte = BussEstado.Listar();
                    // idestado.Items.Add(new ListItem("Seleccione..", ""));
                    foreach (DataRow r in dte.Rows)
                    {
                        string texto = r["descripcion"].ToString();
                        string valor = r["idestado"].ToString();
                        if (valor.Equals("1"))
                        {
                            idestado.Items.Add(new ListItem(texto, valor));
                        }
                    }

                    int id = Convert.ToInt32(Request["id"].ToString());

                    Hora obj = BussHora.Buscar(id);
                    if (obj != null)
                    {
                        idhora.Text = obj.Idhora.ToString();
                        fecha.Text = obj.FechaTxt.ToString();
                        horaminuto.Text = obj.HoraminutoTxt.ToString();
                        idmedico.Text = obj.Medico.Idmedico.ToString();
                        idestado.Text = obj.Estado.Idestado.ToString();
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
                Hora obj = new Hora();

                obj.Idhora = int.Parse(idhora.Text);
                obj.Fecha = DateTime.Parse(fecha.Text);
                obj.Horaminuto = TimeSpan.Parse(horaminuto.Text);

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(idestado.Text);

                BussHora.Update(obj);

                Response.Redirect("horalistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }
}