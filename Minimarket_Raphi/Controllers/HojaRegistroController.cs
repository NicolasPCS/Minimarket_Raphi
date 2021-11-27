using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minimarket_Raphi.Datos;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Controllers
{
    public class HojaRegistroController : Controller
    {
        HojaRegistroAdmin admin = new HojaRegistroAdmin();
        // GET: HojaRegistroAdmin
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
        public ActionResult Guardar(Hoja_de_Registro modelo)
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
        public ActionResult Edit(String id, Hoja_de_Registro datosUpdate)
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

        public ActionResult Modificar(Hoja_de_Registro modelo)
        {
            admin.Modificar(modelo); return View("Editar", modelo);
        }
        public ActionResult Eliminar(string id)
        {
            Hoja_de_Registro modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }












        public ActionResult NuevaHoja_de_Registro(string ID_HojaRegistro, Nullable<int> Saldo_Final_Mensual, string Codigo_Empleado, string Area, string Turno, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio, string ID_Kardex)
        {
            if (Codigo_Empleado == null)
            {
                return View();
            }
            else
            {
                Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                Nuevo.sp_nuevo_hojaRegistro(ID_HojaRegistro, Saldo_Final_Mensual, Codigo_Empleado, Area, Turno, Dia, Mes, Anio, ID_Kardex);
                Nuevo.SaveChanges();
                return View();
            }
        }
        public ActionResult ActualizarHoja_de_Registro(string ID_HojaRegistro, Nullable<int> Saldo_Final_Mensual, string Codigo_Empleado, string Area, string Turno, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio, string ID_Kardex)
        {
            if (Codigo_Empleado == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Hoja_de_Registro.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_actualizar_hojaRegistro(ID_HojaRegistro, Saldo_Final_Mensual, Codigo_Empleado, Area, Turno, Dia, Mes, Anio, ID_Kardex);
                    Nuevo.SaveChanges();
                    return View(contexto.Hoja_de_Registro.AsNoTracking().ToList());
                }
            }

        }
        public ActionResult EliminarHoja_de_Registro(string Codigo_Hoja_de_Registro)
        {
            if (Codigo_Hoja_de_Registro == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Hoja_de_Registro.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {

                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_eliminar_hojaRegistro(Codigo_Hoja_de_Registro);
                    Nuevo.SaveChanges();
                    return View(contexto.Hoja_de_Registro.AsNoTracking().ToList());
                }
            }
        }






    }
}