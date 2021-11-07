using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class Subfamilia_ProductoAdmin
    {
        public IEnumerable<Subfamilia_Producto> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Subfamilia_Producto.AsNoTracking().ToList();
            }
        }
        public Subfamilia_Producto Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Subfamilia_Producto.AsNoTracking().FirstOrDefault(c => c.Subfamilia == id);
            }
        }
        public void Guardar(Subfamilia_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Subfamilia_Producto.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Subfamilia_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Subfamilia_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}