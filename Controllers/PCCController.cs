using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlHrsConsultoria.Models;
using ControlHrsConsultoria.Models.ViewModel;

namespace ControlHrsConsultoria.Controllers
{
    public class PCCController : Controller
    {
        // GET: Consultor
        public ActionResult Index()
        {
            List<ListPCCViewModel> lst;
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                lst = (from d in db.Proyecto_Consultor_Cliente
                       select new ListPCCViewModel
                       {
                           idDetalle = d.idDetalle,
                           idProyecto = (int)d.idProyecto,
                           idConsultor = (int)d.idConsultor,
                           idPerfil = (int)d.idPerfil,
                           idCliente = (int)d.idCliente,
                           montoPrecio = d.montoPrecio,
                           costo = d.costo,
                           descripcion = d.descripcion,
                           fechaInicio = d.fechaInicio,
                           fechaFinal = d.fechaFinal,
                           cantidadHrs = d.cantidadHrs
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult Editar(int id)
        {
            PCCViewModel model = new PCCViewModel();
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                var oTabla = db.Proyecto_Consultor_Cliente.Find(id);
                model.descripcion = oTabla.descripcion;
                model.fechaInicio = oTabla.fechaInicio;
                model.fechaFinal = oTabla.fechaFinal;
                model.cantidadHrs = oTabla.cantidadHrs;
                model.idDetalle = oTabla.idDetalle;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(PCCViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    decimal horas;
                    using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
                    {
                        var oTabla = db.Proyecto_Consultor_Cliente.Find(model.idDetalle);
                        horas = (decimal)oTabla.cantidadHrs + (decimal)model.cantidadHrs;
                        oTabla.idDetalle = oTabla.idDetalle;
                        oTabla.idProyecto = oTabla.idProyecto;
                        oTabla.idConsultor = oTabla.idConsultor;
                        oTabla.idPerfil = oTabla.idPerfil;
                        oTabla.montoPrecio = oTabla.montoPrecio;
                        oTabla.costo = oTabla.costo;
                        oTabla.descripcion = model.descripcion;
                        oTabla.fechaInicio = model.fechaInicio;
                        oTabla.fechaFinal = model.fechaFinal;
                        oTabla.cantidadHrs = horas;
                        oTabla.idCliente = oTabla.idCliente;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/PCC/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inner exception: {0}", ex.InnerException);
                throw new Exception(ex.Message);
            }
        }
    }
}