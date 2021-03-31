using ControlHrsConsultoria.Models;
using ControlHrsConsultoria.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlHrsConsultoria.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult Index()
        {
            List<ProyectoViewModel> lst;

            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                lst = (from d in db.Proyecto
                       select new ProyectoViewModel
                       {
                           IdProyecto = d.idProyecto,
                           Nombre = d.nombre,
                           Descripcion = d.descripcion,
                           FechaInicio = d.fechaInicio,
                           FechaFinal = d.fechaFinal,
                           MontoPrecio = d.montoPrecio,
                           Costo = d.costo,
                           Status = d.status
                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(FProyectoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
                    {
                        var oProyecto = new Proyecto();

                        oProyecto.nombre = model.Nombre;
                        oProyecto.descripcion = model.Descripcion;
                        oProyecto.fechaInicio = model.FechaInicio;
                        oProyecto.fechaFinal = model.FechaFinal;
                        oProyecto.montoPrecio = model.MontoPrecio;
                        oProyecto.costo = model.Costo;
                        oProyecto.status = model.Status;


                        db.Proyecto.Add(oProyecto);
                        db.SaveChanges();
                    }
                    return Redirect("~/Proyecto/");
                }
                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ActionResult Editar(int Id)
        {
            FProyectoViewModel model = new FProyectoViewModel();
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                var oProyecto = db.Proyecto.Find(Id);

                model.IdProyecto = oProyecto.idProyecto;
                model.Nombre = oProyecto.nombre;
                model.Descripcion = oProyecto.descripcion;
                model.FechaInicio = oProyecto.fechaInicio;
                model.FechaFinal = oProyecto.fechaFinal;
                model.MontoPrecio = oProyecto.montoPrecio;
                model.Costo = oProyecto.costo;
                model.Status = (bool)oProyecto.status;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(FProyectoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
                    {
                        var oProyecto = db.Proyecto.Find(model.IdProyecto);

                        oProyecto.nombre = model.Nombre;
                        oProyecto.descripcion = model.Descripcion;
                        oProyecto.fechaInicio = model.FechaInicio;
                        oProyecto.fechaFinal = model.FechaFinal;
                        oProyecto.montoPrecio = model.MontoPrecio;
                        oProyecto.costo = model.Costo;
                        oProyecto.status = model.Status;


                        db.Entry(oProyecto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Proyecto/");
                }
                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                var oProyecto = db.Proyecto.Find(Id);
                db.Proyecto.Remove(oProyecto);
                db.SaveChanges();

            }
            return Redirect("~/Proyecto/");
        }
    }
}