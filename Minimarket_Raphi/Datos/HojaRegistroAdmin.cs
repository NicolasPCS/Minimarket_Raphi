using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class HojaRegistroAdmin
    {
        public IEnumerable<Hoja_de_Registro> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Hoja_de_Registro.AsNoTracking().ToList();
            }
        }
        public Hoja_de_Registro Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Hoja_de_Registro.AsNoTracking().FirstOrDefault(c => c.ID_HojaRegistro == id);
            }
        }
        public void Guardar(Hoja_de_Registro modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Hoja_de_Registro.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Hoja_de_Registro modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Hoja_de_Registro modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}