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
    }
}