using Model.Entity;
using Model.Entity.Moldes;
using Model.Neg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWeb.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
          var lista=  DepartamentoNeg.Mostrar();
            return View(lista);
        }

        public JsonResult ObtenerDepartamento()
        {
            var lista = DepartamentoNeg.Mostrar();
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Departamento departamento)
        {
            DepartamentoNeg.Agregar(departamento);
            return RedirectToAction("index");
        }


        [HttpGet]
        public ActionResult Editar(int id)
        {
          var lista=  DepartamentoNeg.ObtenerID(id);
            return View(lista);
        }
        [HttpPost]
        public ActionResult Editar(Departamento departamento)
        {
            DepartamentoNeg.Modificar(departamento);
            return RedirectToAction("index");
        }







        public ActionResult Eliminar(int id)
        {
           DepartamentoNeg.Eliminar(id);
            return RedirectToAction("Index");
        }

        public ActionResult AgruparporCliente(int id)
        {
            ClienteEntity neg = new ClienteEntity();
            neg.DepartamentoId = id;
            List<ClienteEntity> obj = DepartamentoNeg.MostrarClient(neg);
            return View(obj);
        }
    }
}