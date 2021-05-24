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
    public partial class medicolistar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // colocar validación de inicio de sesión

            LlenarTabla();
        }

        public void LlenarTabla()
        {
            TableRow r;
            TableCell c;

            List<Medico> lista = BussMedico.Listar02();
            foreach (Medico obj in lista)
            {
                r = new TableRow();      // instanciamos una nueva TableRow
                tblMedicos.Rows.Add(r);  // lo agregamos a la tabla

                // instancias de las celdas y se agregan a la fifa r
                c = new TableCell(); c.Text = obj.Idmedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.NomMedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Email.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Telefono.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.NomEspecialidad; r.Cells.Add(c);
            }
        }
    }
}