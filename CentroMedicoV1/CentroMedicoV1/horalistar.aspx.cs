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
    public partial class horalistar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Session["login"].Equals("N3T4CC3SS")){
                Response.Redirect("index.aspx");
            }

            LlenarTabla();
        }

        public void LlenarTabla()
        {
            TableRow r;
            TableCell c;

            List<Hora> lista = BussHora.Listar02(1);
            foreach (Hora item in lista)
            {
                // instaciamos un TableRow y se lo agregamos a la tabla
                r = new TableRow();
                tblHora.Rows.Add(r);

                // instanciar una TableCell, la llenamos y la agregamos al TableRow r
                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = item.Idhora.ToString(); 
                r.Cells.Add(c);

                // usamos la propiedad get FechaTxt 
                c = new TableCell(); c.Text = item.FechaTxt.ToString(); r.Cells.Add(c);
                // usamos la propiedad get HoramoinutoTxt
                c = new TableCell(); c.Text = item.HoraminutoTxt.ToString(); r.Cells.Add(c);
                // usamos las propiedades get NomMedico y NomEspecialidad
                c = new TableCell(); c.Text = item.Medico.NomMedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = item.Medico.NomEspecialidad.ToString(); r.Cells.Add(c);

                c = new TableCell(); c.Text = item.Estado.Descripcion.ToString(); r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='horaeditar.aspx?id="+ item.Idhora.ToString() + "'>Editar</a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='horaborrar.aspx?id=" + item.Idhora.ToString() + "'>Borrar</a>";
                r.Cells.Add(c);
            }
        }
    }
}