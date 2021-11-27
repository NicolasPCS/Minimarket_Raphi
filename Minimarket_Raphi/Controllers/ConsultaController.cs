using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;
using Minimarket_Raphi.Models;
using System.Web.UI.WebControls;
using System.Web.UI;



namespace Minimarket_Raphi.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: ConsultaController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Montoventa1()
        {
            Minimarket_RaphiEntities Consul1 = new Minimarket_RaphiEntities();
            ObjectResult<consulta_monto_de_venta_Result> Listaoperaciones = null;
            Listaoperaciones = Consul1.consulta_monto_de_venta();
            return View(Listaoperaciones);
        }
        public ActionResult SaldoInicial2()
        {
            Minimarket_RaphiEntities Consul2 = new Minimarket_RaphiEntities();
            ObjectResult<consulta_saldos_inciales_Result> Listaoperaciones = null;
            Listaoperaciones = Consul2.consulta_saldos_inciales();
            return View(Listaoperaciones);

        }
        public ActionResult InformacionEmpleado3()
        {

            Minimarket_RaphiEntities Consul3 = new Minimarket_RaphiEntities();
            ObjectResult<informacion_empleado_Result> Listaoperaciones = null;
            Listaoperaciones = Consul3.informacion_empleado();
            return View(Listaoperaciones);

        }

        //////////


        public ActionResult EmpleadoHojadeRegistro4()
        {

            Minimarket_RaphiEntities Consul4 = new Minimarket_RaphiEntities();
            ObjectResult<Empleado_en_Hoja_de_Registro_Result> Listaoperaciones = null;
            Listaoperaciones = Consul4.Empleado_en_Hoja_de_Registro();
            return View(Listaoperaciones);

        }
        public ActionResult RetiroyEntradas5()
        {

            Minimarket_RaphiEntities Consul5 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Retiro_y_Entradas_Result> Listaoperaciones = null;
            Listaoperaciones = Consul5.Consulta_Retiro_y_Entradas();
            return View(Listaoperaciones);

        }
        public ActionResult TurnoEmpleado6()
        {

            Minimarket_RaphiEntities Consul6 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Turno_Empleados_Result> Listaoperaciones = null;
            Listaoperaciones = Consul6.Consulta_Turno_Empleados();
            return View(Listaoperaciones);

        }
        public ActionResult SaldoInicialAño7()
        {

            Minimarket_RaphiEntities Consul7 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Saldo_Inicial_Año_Result> Listaoperaciones = null;
            Listaoperaciones = Consul7.Consulta_Saldo_Inicial_Año();
            return View(Listaoperaciones);

        }
        public ActionResult ConsultaEmpleado8()
        {

            Minimarket_RaphiEntities Consul8 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Control_empleados_Result> Listaoperaciones = null;
            Listaoperaciones = Consul8.Consulta_Control_empleados();
            return View(Listaoperaciones);

        }
        public ActionResult ConsultaGanancia9()
        {

            Minimarket_RaphiEntities Consul9 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Ganancia_Result> Listaoperaciones = null;
            Listaoperaciones = Consul9.Consulta_Ganancia();
            return View(Listaoperaciones);

        }
        public ActionResult ConsultaEmpleadoSueldo10()
        {

            Minimarket_RaphiEntities Consul10 = new Minimarket_RaphiEntities();
            ObjectResult<Consulta_Empleado_Sueldo_Result> Listaoperaciones = null;
            Listaoperaciones = Consul10.Consulta_Empleado_Sueldo();
            return View(Listaoperaciones);

        }
























    }
}