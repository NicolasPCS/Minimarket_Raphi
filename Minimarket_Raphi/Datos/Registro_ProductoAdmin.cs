using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class Registro_ProductoAdmin
    {
        public IEnumerable<Registro_Producto> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Registro_Producto.AsNoTracking().ToList();
            }
        }
        public Registro_Producto Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Registro_Producto.AsNoTracking().FirstOrDefault(c => c.Codigo_Producto == id);
            }
        }
        public void Guardar(Registro_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Registro_Producto.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Registro_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Registro_Producto modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}