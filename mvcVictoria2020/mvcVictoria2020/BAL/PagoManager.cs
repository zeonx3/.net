using Models;
using mvcVictoria2020.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BAL
{
    public class PagoManager
    {
        BaseDatos db = new BaseDatos();

        public List<PagoModel> Listar()
        {
            var lista = (from p in db.pago
                         join r in db.reserva on p.idreserva equals r.idreserva
                         join c in db.cliente on r.idcliente equals c.idcliente
                         join h in db.habitacion on r.idhabitacion equals h.idhabitacion
                         select new PagoModel
                         {
                             idpago = p.idpago,
                             idreserva = p.idreserva,
                             montopago = p.montopago,
                             estado = p.estado,
                             // Habitacion
                             numhab = h.numhab,
                             detalle = h.detalle,
                             valordia = h.valordia,
                             //cliente
                             nombres = c.nombres,
                             apellidos = c.apellidos,
                             email = c.email,
                             telefono = c.telefono,
                             //Reserva
                             fecha = r.fecha,
                             numdias = r.numdias,
                             fechaout = r.fechaout

                         }).ToList();
            return lista;
        }

        public PagoModel Buscar(int id)
        {
            var obj = (from p in db.pago
                         join r in db.reserva on p.idreserva equals r.idreserva
                         join c in db.cliente on r.idcliente equals c.idcliente
                         join h in db.habitacion on r.idhabitacion equals h.idhabitacion
                         where p.idpago == id
                         select new PagoModel
                         {
                             idpago = p.idpago,
                             idreserva = p.idreserva,
                             montopago = p.montopago,
                             estado = p.estado,
                             // Habitacion
                             numhab = h.numhab,
                             detalle = h.detalle,
                             valordia = h.valordia,
                             //cliente
                             nombres = c.nombres,
                             apellidos = c.apellidos,
                             email = c.email,
                             telefono = c.telefono,
                             //Reserva
                             fecha = r.fecha,
                             numdias = r.numdias,
                             fechaout = r.fechaout

                         }).FirstOrDefault();
            return obj;
        }

        public int Borrar(int id)
        {
            try
            {
                var entidad = db.pago.Find(id);
                db.pago.Remove(entidad);
                db.SaveChanges();
                return entidad.idpago;
            }
            catch (Exception exe)
            {
                return 0;
            }
        }

        public long Crear(PagoModel obj)
        {
            try
            {
                var entidad = new pago();
                entidad.idpago = obj.idpago;
                entidad.idreserva = obj.idreserva;
                entidad.montopago = obj.montopago;
                entidad.estado = obj.estado;
                db.pago.Add(entidad);
                db.SaveChanges();
                return entidad.idpago;
            }
            catch (Exception exe)
            {
                return 0;
            }

        }
        public long Editar(PagoModel obj)
        {
            try
            {
                var entidad = db.pago.Find(obj.idpago);
                entidad.idreserva = obj.idreserva;
                entidad.montopago = obj.montopago;
                entidad.estado = obj.estado;
                db.pago.AddOrUpdate(entidad);
                db.SaveChanges();
                return entidad.idpago;
            }
            catch (Exception exe)
            {
                return 0;
            }

        }




        public List<ListasModel> Habitaciones()
        {
            var man = new ListasManager();
            return man.Habitaciones();
        }

        public List<ListasModel> Clientes()
        {
            var man = new ListasManager();
            return man.Clientes();
        }

        public List<ListasModel> Reservas()
        {
            var man = new ListasManager();
            return man.Reservas();
        }
    }
}