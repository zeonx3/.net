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
    public partial class horanuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

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
            idestado.Items.Add(new ListItem("Seleccione..", ""));
            foreach (DataRow r in dte.Rows)
            {
                string texto = r["descripcion"].ToString();
                string valor = r["idestado"].ToString();
                if (valor.Equals("1"))
                {
                    idestado.Items.Add(new ListItem(texto, valor));
                }
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Hora obj = new Hora();

                obj.Idhora = 0;
                obj.Fecha = DateTime.Parse(fecha.Text);
                obj.Horaminuto = TimeSpan.Parse(horaminuto.Text);

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(idestado.Text);

                BussHora.Insert(obj);

                Response.Redirect("horalistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }
}