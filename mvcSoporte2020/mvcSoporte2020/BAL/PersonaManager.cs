using BAL;
using DataSoporte2020.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;  // gracias master
using System.Web;

namespace BAL
{
    public class PersonaManager
    {
        BaseDatos db = new BaseDatos();

        public List<PersonaModel> Listar()
        {
            var lista = (from p in db.persona
                         join co in db.tbl_comuna on p.idcomuna equals co.idcomuna
                         select new PersonaModel
                         {
                             idpersona = p.idpersona,
                             rut = p.rut,
                             dv = p.dv,
                             ap_paterno = p.ap_paterno,
                             ap_materno = p.ap_materno,
                             nombres = p.nombres,
                             email = p.email,
                             telefono = p.telefono,
                             dir_calle = p.dir_calle,
                             dir_numero = p.dir_numero,
                             idcomuna = p.idcomuna,
                             desc_comuna = co.desc_comuna
                         }).ToList();
            return lista;
        }

        public PersonaModel Buscar(long id)
        {
            var obj = (from p in db.persona
                       join co in db.tbl_comuna on p.idcomuna equals co.idcomuna
                       where p.idpersona == id
                       select new PersonaModel
                       {
                           idpersona = p.idpersona,
                           rut = p.rut,
                           dv = p.dv,
                           ap_paterno = p.ap_paterno,
                           ap_materno = p.ap_materno,
                           nombres = p.nombres,
                           email = p.email,
                           telefono = p.telefono,
                           dir_calle = p.dir_calle,
                           dir_numero = p.dir_numero,
                           idcomuna = p.idcomuna,
                           desc_comuna = co.desc_comuna
                       }).FirstOrDefault();
            return obj;
        }

        public long Crear(PersonaModel obj)
        {
            var entidad = new persona();
            entidad.rut = obj.rut;
            entidad.dv = obj.dv;
            entidad.ap_paterno = obj.ap_paterno;
            entidad.ap_materno = obj.ap_materno;
            entidad.nombres = obj.nombres;
            entidad.email = obj.email;
            entidad.telefono = obj.telefono;
            entidad.dir_calle = obj.dir_calle;
            entidad.dir_numero = obj.dir_numero;
            entidad.idcomuna = obj.idcomuna;
            db.persona.Add(entidad);
            db.SaveChanges();
            return entidad.idpersona;
        }

        public long Editar(PersonaModel obj)
        {
            var entidad = db.persona.Find(obj.idpersona); // ahora si
            entidad.rut = obj.rut;
            entidad.dv = obj.dv;
            entidad.ap_paterno = obj.ap_paterno;
            entidad.ap_materno = obj.ap_materno;
            entidad.nombres = obj.nombres;
            entidad.email = obj.email;
            entidad.telefono = obj.telefono;
            entidad.dir_calle = obj.dir_calle;
            entidad.dir_numero = obj.dir_numero;
            entidad.idcomuna = obj.idcomuna;
            db.persona.AddOrUpdate(entidad);
            db.SaveChanges();
            return entidad.idpersona;
        }

        public long Borrar(long id)
        {
            var entidad = db.persona.Find(id);
            db.persona.Remove(entidad);
            db.SaveChanges();
            return entidad.idpersona;
        }
    }
}
