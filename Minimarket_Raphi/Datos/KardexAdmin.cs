using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class KardexAdmin
    {
        public IEnumerable<Kardex> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Kardex.AsNoTracking().ToList();
            }
        }
        public Kardex Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Kardex.AsNoTracking().FirstOrDefault(c => c.ID_Kardex == id);
            }
        }
        public void Guardar(Kardex modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Kardex.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Kardex modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Kardex modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}