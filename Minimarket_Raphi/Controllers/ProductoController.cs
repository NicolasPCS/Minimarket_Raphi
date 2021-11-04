using Minimarket_Raphi.Datos;
using Minimarket_Raphi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimarket_Raphi.Controllers
{
    public class ProductoController : Controller
    {
        ProductoAdmin admin = new ProductoAdmin();
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
        public ActionResult Guardar(Producto modelo)
        {
            admin.Guardar(modelo); return View("Crear", modelo);
        }
        public ActionResult Editar(string id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(Producto modelo)
        {
            admin.Modificar(modelo); return View("Editar", modelo);
        }
        public ActionResult Eliminar(string id)
        {
            Producto modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }
    }
}