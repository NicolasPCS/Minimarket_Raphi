using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class ProductoAdmin
    {
        public IEnumerable<Producto> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Producto.AsNoTracking().ToList();
            }
        }
        public Producto Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Producto.AsNoTracking().FirstOrDefault(c => c.Codigo_Producto == id);
            }
        }
        public void Guardar(Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Producto.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}