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
    public class ClienteController : Controller
    {

        // GET: Cliente

        //Mostrar Cliente
        public ActionResult Index()
        {
            var lista = ClienteNeg.Mostrar();
            return View(lista);
        }

        //Agregar Cliente
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Cliente cliente)
        {
            try
            {
                ClienteNeg.Agregar(cliente);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Ocurrió un error al agregar un Empleado");
                //return View();
            }
        }
        //Eliminar Cliente
        public ActionResult Eliminar(int id)
        {

            try
            {
                ClienteNeg.Eliminar(id);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }

        //Mostrar Empleado con su Direccion


       
      
    }
}