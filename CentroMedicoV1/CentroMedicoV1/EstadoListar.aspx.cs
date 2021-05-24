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
    public partial class EstadoListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }
        public void LlenarTabla()
        {
            TableRow r;
            TableCell c;

            List<Estado> lista = BussEstado.Listar02();
            foreach (Estado obj in lista)
            {
                r = new TableRow();
                tblestado.Rows.Add(r);
                c = new TableCell(); c.Text = obj.Idestado.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Descripcion.ToString(); r.Cells.Add(c);


                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='EstadoEditar.aspx?id=" + obj.Idestado.ToString() + "'>Editar</a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='EstadoBorrar.aspx?id=" + obj.Idestado.ToString() + "'>Borrar</a>";
                r.Cells.Add(c);
            }
        }
    }
}