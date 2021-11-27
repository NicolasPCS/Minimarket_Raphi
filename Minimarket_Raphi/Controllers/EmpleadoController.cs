using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minimarket_Raphi.Datos;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoAdmin admin = new EmpleadoAdmin();
        // GET: Empleado
        public ActionResult Index()
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(string id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(Empleado modelo)
        {
            admin.Guardar(modelo); return View("Crear", modelo);
        }
        public ActionResult Editar(string id)
        {
            return View(admin.Consultar(id));
        }

        // Se agrego solo el siguiente fragmento de codigo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(String id, Empleado datosUpdate)
        {
            try
            {
                admin.Consultar(id);

                if(admin != null)
                {
                    admin.Modificar(datosUpdate);
                }

                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }
        // Hasta aqui

        public ActionResult Modificar(Empleado modelo)
        {
            admin.Modificar(modelo); return View("Editar", modelo);
        }
        public ActionResult Eliminar(string id)
        {
            Empleado modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }








        public ActionResult NuevoEmpleado(string Codigo_Empleado, Nullable<decimal> Sueldo, string Nombre_Pila, string Apellido_Paterno, string Apellido_Materno, Nullable<System.DateTime> Fecha_Modificacion, string Accion_Ejecutada)
        {
            if (Codigo_Empleado == null)
            {
                return View();
            }
            else
            {
                Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                Nuevo.sp_nuevo_empleado(Codigo_Empleado, Sueldo, Nombre_Pila, Apellido_Paterno, Apellido_Materno, Fecha_Modificacion, Accion_Ejecutada);
                Nuevo.SaveChanges();
                return View();
            }
        }
        public ActionResult ActualizarEmpleado(string Codigo_Empleado, Nullable<decimal> Sueldo, string Nombre_Pila, string Apellido_Paterno, string Apellido_Materno, Nullable<System.DateTime> Fecha_Modificacion, string Accion_Ejecutada)
        {
            if (Codigo_Empleado == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Empleado.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_actualizar_empleado(Codigo_Empleado, Sueldo, Nombre_Pila, Apellido_Paterno, Apellido_Materno, Fecha_Modificacion, Accion_Ejecutada);
                    Nuevo.SaveChanges();
                    return View(contexto.Empleado.AsNoTracking().ToList());
                }
            }

        }
        public ActionResult EliminarEmpleado(string Codigo_Empleado)
        {
            if (Codigo_Empleado == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Empleado.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {

                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_eliminar_empleado(Codigo_Empleado);
                    Nuevo.SaveChanges();
                    return View(contexto.Empleado.AsNoTracking().ToList());
                }
            }
        }










    }
}