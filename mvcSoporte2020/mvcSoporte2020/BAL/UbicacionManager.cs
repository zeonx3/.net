using DataSoporte2020.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace BAL
{
    public class UbicacionManager
    {
        BaseDatos db = new BaseDatos();

        public List<ComunaModel> ComunaListar(int idpro, int idreg)
        {
            var lista = (from co in db.tbl_comuna
                         join pr in db.tbl_provincia on co.idprovincia equals pr.idprovincia
                         join re in db.tbl_region on co.idregion equals re.idregion
                         where co.idprovincia == idpro
                         && co.idregion == idreg
                         select new ComunaModel
                         {
                             idcomuna = co.idcomuna,
                             idprovincia = co.idprovincia,
                             idregion = co.idregion,
                             desc_comuna = co.desc_comuna,
                             desc_provincia = pr.desc_provincia,
                             desc_region = re.desc_region
                         }).ToList();
            return lista;
        }
    }
}