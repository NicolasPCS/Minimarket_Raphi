using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Datos
{
    public class EmpleadoAdmin
    {
        public IEnumerable<Empleado> Consultar()
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Empleado.AsNoTracking().ToList();
            }
        }
        public Empleado Consultar(string id)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                return contexto.Empleado.AsNoTracking().FirstOrDefault(c => c.Codigo_Empleado == id);
            }
        }
        public void Guardar(Empleado modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Empleado.Add(modelo); contexto.SaveChanges();
            }
        }
        public void Modificar(Empleado modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Empleado modelo)
        {
            using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}