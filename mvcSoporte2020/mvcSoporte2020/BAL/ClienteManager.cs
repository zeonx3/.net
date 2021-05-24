using DataSoporte2020.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BAL
{
    public class ClienteManager
    {
        BaseDatos db = new BaseDatos();

        public List<ClienteModel> Listar()
        {
            var lista = (from c in db.cliente
                         join tp in db.tipoplan on c.idplan equals tp.idplan
                         select new ClienteModel
                         {
                             idcliente = c.idcliente,
                             idpersona = c.idpersona,
                             fechaini = c.fechaini,
                             idplan = c.idplan,
                             desc_plan = tp.desc_plan,
                             costo = tp.costo
                         }).ToList();
            return lista;
        }

        public ClienteModel Buscar(long id)
        {
            var obj = (from c in db.cliente
                       join tp in db.tipoplan on c.idplan equals tp.idplan
                       where c.idcliente == id
                       select new ClienteModel
                       {
                           idcliente = c.idcliente,
                           idpersona = c.idpersona,
                           fechaini = c.fechaini,
                           idplan = c.idplan,
                           desc_plan = tp.desc_plan,
                           costo = tp.costo
                       }).FirstOrDefault();
            return obj;
        }

        public long Crear(ClienteModel obj)
        {
            var entidad = new cliente();
            entidad.idpersona = obj.idpersona;
            entidad.idplan = obj.idplan;
            entidad.fechaini = DateTime.Now;
            db.cliente.Add(entidad);
            db.SaveChanges();
            return entidad.idcliente;
        }

        public long Editar(ClienteModel obj)
        {
            var entidad = db.cliente.Find(obj.idcliente);
            entidad.idpersona = obj.idpersona;
            entidad.idplan = obj.idplan;
            entidad.fechaini = DateTime.Now;
            db.cliente.AddOrUpdate(entidad);
            db.SaveChanges();
            return entidad.idcliente;
        }

        public long Borrar(long id)
        {
            var entidad = db.cliente.Find(id);
            db.cliente.Remove(entidad);
            db.SaveChanges();
            return entidad.idcliente;
        }


        public List<tipoplan> Planes()
        {
            return db.tipoplan.ToList();
        }

        public List<PersonaModel> Personas()
        {
            var per = new PersonaManager();
            return per.Listar();
        }
    }
}