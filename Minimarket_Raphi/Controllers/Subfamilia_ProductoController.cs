using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minimarket_Raphi.Datos;
using Minimarket_Raphi.Models;

namespace Minimarket_Raphi.Controllers
{
    public class Subfamilia_ProductoController : Controller
    {
        Subfamilia_ProductoAdmin admin = new Subfamilia_ProductoAdmin();
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
        public ActionResult Guardar(Subfamilia_Producto modelo)
        {
            admin.Guardar(modelo); return View("Crear", modelo);
        }
        public ActionResult Editar(string id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(Subfamilia_Producto modelo)
        {
            admin.Modificar(modelo); return View("Editar", modelo);
        }
        public ActionResult Eliminar(string id)
        {
            Subfamilia_Producto modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }
    }
}