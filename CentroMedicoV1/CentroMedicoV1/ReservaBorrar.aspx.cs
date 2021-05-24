using CentroMedicoV1.Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {

                    int id = Convert.ToInt32(Request["id"].ToString());
                    Reserva obj = BussReserva.Buscar(id);
                    if (obj != null)
                    {
                        idreserva.Text = id.ToString();
                        idpaciente.Text = obj.Paciente.NomPaciente.ToString();
                        idmedico.Text = obj.Medico.NomMedico.ToString();
                        idhora.Text = obj.Hora.FechaTxt.ToString();
                    }
                    else
                    {
                        Response.Redirect("ReservaListar.aspx");
                    }
                }
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"].ToString());
            
            
            
            try
            {
                Reserva obj = new Reserva();
                obj.Idreserva = id;
                BussReserva.delete(obj);
                Response.Redirect("ReservaListar.aspx");

            }
            catch (Exception exe)
            {

            }

        }
    }
}