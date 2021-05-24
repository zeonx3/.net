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
    public partial class MedicoNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // llenar el DropDownList idespecialidad
            DataTable dt = BussEspecialidad.Listar();
            idespecialidad.Items.Add(new ListItem("Seleccionar...", ""));
            foreach(DataRow row in dt.Rows)
            {
                string texto = row["descripcion"].ToString();
                string valor = row["idespecialidad"].ToString();
                idespecialidad.Items.Add(new ListItem(texto, valor));
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico obj = new Medico();
                obj.Idmedico = 0;
                obj.Nombres = nombres.Text;
                obj.Apellidos = apellidos.Text;
                obj.Email = email.Text;
                obj.Telefono = int.Parse(telefono.Text);

                obj.Especialidad = new Especialidad();
                obj.Especialidad.Idespecialidad = int.Parse(idespecialidad.Text);

                BussMedico.Insert(obj);

                Response.Redirect("medicolistar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}