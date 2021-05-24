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
    public partial class ReservaListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             DataTable dtm = BussMedico.Listar();
            idmedico.Items.Add(new ListItem("Todos los Medicos", "0"));
            foreach (DataRow r in dtm.Rows)
            {
                string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                string valor = r["idmedico"].ToString();
                idmedico.Items.Add(new ListItem(texto, valor));
            }
            DataTable dte = BussEspecialidad.Listar();
            idespecialidad.Items.Add(new ListItem("Todas las Especialidades", "0"));
            foreach (DataRow r in dte.Rows)
            {
                string texto = r["descripcion"].ToString();
                string valor = r["idespecialidad"].ToString();
                idespecialidad.Items.Add(new ListItem(texto, valor));
            }
            DataTable dtf = BussHora.comb();
            idhora.Items.Add(new ListItem("Todas las Horas", "0"));
            foreach (DataRow r in dtf.Rows)
            {
                string texto = r["fecha"].ToString() + " " + r["horaminuto"].ToString();
                string valor = r["idhora"].ToString();
                idhora.Items.Add(new ListItem(texto, valor));
            }


            
                LlenarTabla(0, 0, 0);
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idmed = int.Parse(idmedico.Text);
            int idesp = int.Parse(idespecialidad.Text);
            int idhor = int.Parse(idhora.Text);

            LlenarTabla(idhor,idmed, idesp);
        }

        public void LlenarTabla(int idhor,int idmed, int idesp)
        {
            TableRow r;
            TableCell c;

            List<Reserva> lista = BussReserva.Listar02(idhor,idmed, idesp);
            foreach (Reserva obj in lista)
            {
                r = new TableRow();
                tblreserva.Rows.Add(r);
                c = new TableCell(); c.Text = obj.Idreserva.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Hora.FechaTxt.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Hora.HoraminutoTxt.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Medico.NomMedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Medico.NomEspecialidad.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Paciente.NomPaciente.ToString(); r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='ReservaEditar.aspx?id=" + obj.Idreserva.ToString() + "'><img border='0' src='img/editar.png'></a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='ReservaBorrar.aspx?id=" + obj.Idreserva.ToString() + "'><img border='0' src='img/borrar.png'></a>";
                r.Cells.Add(c);
            }
        }

    }
}
    
