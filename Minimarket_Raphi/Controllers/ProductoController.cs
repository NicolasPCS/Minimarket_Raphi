using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Minimarket_Raphi.Models;
using Minimarket_Raphi.Datos;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Data.SqlClient;

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

        public ActionResult NuevoProducto(string Codigo, string Nombre, string Descripcion, string Categoria, string Subfamilia, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio, Nullable<decimal> Precio)
        {
            if (Codigo == null)
            {
                return View();
            }
            else
            {
                Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                Nuevo.sp_nuevo_producto(Codigo, Nombre, Descripcion, Categoria, Subfamilia, Dia, Mes, Anio, Precio);
                Nuevo.SaveChanges();
                return View();
            }
        }
        public ActionResult ActualizarProducto(string Codigo, string Nombre, string Descripcion, string Categoria, string Subfamilia, Nullable<int> Dia, Nullable<int> Mes, Nullable<int> Anio, Nullable<decimal> Precio)
        {
            if (Codigo == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Producto.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_actualizar_producto(Codigo, Nombre, Descripcion, Categoria, Subfamilia, Dia, Mes, Anio, Precio);
                    Nuevo.SaveChanges();
                    return View(contexto.Producto.AsNoTracking().ToList());
                }
            }

        }

        public ActionResult EliminarProducto(string Codigo)
        {
            if (Codigo == null)
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {
                    return View(contexto.Producto.AsNoTracking().ToList());
                }
            }
            else
            {
                using (Minimarket_RaphiEntities contexto = new Minimarket_RaphiEntities())
                {

                    Minimarket_RaphiEntities Nuevo = new Minimarket_RaphiEntities();
                    Nuevo.sp_eliminar_producto(Codigo);
                    Nuevo.SaveChanges();
                    return View(contexto.Producto.AsNoTracking().ToList());
                }
            }
        }













    }
}