using Buss;
using CentroMedicoV1.Buss;
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
    public partial class ReservaEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["id"] != null)
               {


                    DataTable dtp = BussPaciente.Listar();
                    idpaciente.Items.Add(new ListItem("Seleccione..."));
                    foreach (DataRow r in dtp.Rows)
                    {
                        string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                        string valor = r["idpaciente"].ToString();
                        idpaciente.Items.Add(new ListItem(texto, valor));
                    }
                    DataTable dtf = BussHora.comb2();
                    idhora.Items.Add(new ListItem("Seleccione..."));
                    foreach (DataRow r in dtf.Rows)
                    {
                        string texto = r["fecha"].ToString() + " " + r["horaminuto"].ToString();
                        string valor = r["idhora"].ToString();
                        idhora.Items.Add(new ListItem(texto, valor));
                    }
                    DataTable dte = BussEspecialidad.filtro();
                    idespecialidad.Items.Add(new ListItem("Seleccione..."));
                    foreach (DataRow r in dte.Rows)
                    {
                        string texto = r["descripcion"].ToString();
                        string valor = r["idespecialidad"].ToString();
                        idespecialidad.Items.Add(new ListItem(texto, valor));

                    }

                    int id = Convert.ToInt32(Request["id"].ToString());
                    Reserva obj = BussReserva.Buscar(id);
                    if(obj != null)
                    {
                        idpaciente.Text = obj.Paciente.Idpaciente.ToString();
                        idmedico.Text = obj.Medico.Idmedico.ToString();
                        idespecialidad.Text = obj.Medico.Especialidad.Idespecialidad.ToString();
                        idhora.Text = obj.Hora.Idhora.ToString();
                    }
                    else
                    {
                        Response.Redirect("ReservaListar.aspx");
                    }
                   
                }
                else
                {
                    Response.Redirect("ReservaListar.aspx");
                }
            }


        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"].ToString());

                Reserva obj = new Reserva();
                obj.Idreserva = id;

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(idhora.Text);
                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);
                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(idpaciente.Text);

                BussReserva.Update(obj);

                Response.Redirect("ReservaListar.aspx");

            }
            catch (Exception exe)
            {

            }
        }
        protected void idespecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            var x = int.Parse(idespecialidad.SelectedValue);


            DataTable dtm = BussMedico.filtro(x);
            idmedico.Items.Add(new ListItem("Seleccione..."));
            foreach (DataRow r in dtm.Rows)
            {
                string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                string valor = r["idmedico"].ToString();
                idmedico.Items.Add(new ListItem(texto, valor));

            }

        }
    }
}