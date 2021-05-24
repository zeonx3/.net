using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAL
{
    public class ClienteManager
    {
        BaseDatos db = new BaseDatos();
    
        public List<ClienteModel> Listar()
        {
            var listar = (from c in db.cliente
                          select new ClienteModel
                          {
                              idcliente = c.idcliente,
                              nombres = c.nombres,
                              apellidos = c.apellidos,
                              email = c.email,
                              telefono = c.telefono
                          }).ToList();
            return listar;
        }
    }
}