using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minimarket_Raphi.Datos;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Controllers
{
    public class KardexController : Controller
    {
        KardexAdmin admin = new KardexAdmin();
        // GET: Kardex
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
        public ActionResult Guardar(Kardex modelo)
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
        public ActionResult Edit(String id, Kardex datosUpdate)
        {
            try
            {
                admin.Consultar(id);

                if (admin != null)
                {
                    admin.Modificar(datosUpdate);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // Hasta aqui

        public ActionResult Modificar(Kardex modelo)
        {
            admin.Modificar(modelo); return View("Editar", modelo);
        }
        public ActionResult Eliminar(string id)
        {
            Kardex modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }










        public ActionResult NuevoKardex(string ID_Kardex, Nullable<decimal> Saldo_Inicial, Nullable<decimal> Saldo_Final, Nullable<decimal> Monto_Venta, string Codigo_Empleado, Nullable<decimal> Ganancia, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio)
        {
            if (Codigo_Empleado == null)
            {
                return View();
            }
            else
            {
                Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                Nuevo.sp_nuevo_kardex(ID_Kardex, Saldo_Inicial, Saldo_Final, Monto_Venta, Codigo_Empleado, Ganancia, Dia, Mes, Anio);
                Nuevo.SaveChanges();
                return View();
            }
        }
        public ActionResult ActualizarKardex(string ID_Kardex, Nullable<decimal> Saldo_Inicial, Nullable<decimal> Saldo_Final, Nullable<decimal> Monto_Venta, string Codigo_Empleado, Nullable<decimal> Ganancia, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio)
        {
            if (Codigo_Empleado == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Kardex.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_actualizar_kardex(ID_Kardex, Saldo_Inicial, Saldo_Final, Monto_Venta, Codigo_Empleado, Ganancia, Dia, Mes, Anio);
                    Nuevo.SaveChanges();
                    return View(contexto.Kardex.AsNoTracking().ToList());
                }
            }

        }
        public ActionResult EliminarKardex(string Codigo_Kardex)
        {
            if (Codigo_Kardex == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Kardex.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {

                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_eliminar_kardex(Codigo_Kardex);
                    Nuevo.SaveChanges();
                    return View(contexto.Kardex.AsNoTracking().ToList());
                }
            }
        }







    }
}