using ControlHrsConsultoria.Models;
using ControlHrsConsultoria.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ControlHrsConsultoria.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<ListUsuarioViewModel> lst;
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                lst = (from t in db.Usuario
                           select new Models.ViewModel.ListUsuarioViewModel
                           {
                               idUsuario = t.idUsuario,
                               nombre = t.nombre,
                               apellidos = t.apellidos,
                               correo = t.correo,
                               contraseña = t.contraseña,
                               fechaRegistro = (DateTime)t.fechaRegistro,
                               status = (bool) t.status,
                               idRol = (int) t.idRol
                           }).ToList();
            }

            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(UsuarioViewModel model)
        {
            try 
            {
                if (ModelState.IsValid) 
                {
                    using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
                    {
                        var oUsuario = new Usuario();
                        oUsuario.idUsuario = model.idUsuario;
                        oUsuario.nombre = model.nombre;
                        oUsuario.apellidos = model.apellidos;
                        oUsuario.correo = model.correo;
                        oUsuario.contraseña = model.contraseña;
                        oUsuario.fechaRegistro = model.fechaRegistro;
                        oUsuario.status = model.status;
                        oUsuario.idRol = model.idRol;
                        oUsuario.idCliente = model.idCliente;

                        db.Usuario.Add(oUsuario);
                        db.SaveChanges();
                    }
                    return Redirect("~/Usuario/");

                }
                return View(model);
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public ActionResult Editar(int IdUsuario)
        {
            UsuarioViewModel model = new UsuarioViewModel();
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {
                var oUsuario = db.Usuario.Find(IdUsuario);
                model.idUsuario = oUsuario.idUsuario;
                model.nombre = oUsuario.nombre;
                model.apellidos = oUsuario.apellidos;
                model.correo = oUsuario.correo;
                model.contraseña = oUsuario.contraseña;
                model.fechaRegistro = oUsuario.fechaRegistro;
                model.status = oUsuario.status;
                model.idRol = oUsuario.idRol;
                model.idCliente = oUsuario.idCliente;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(UsuarioViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
                    {
                        var oUsuario = db.Usuario.Find(model.idUsuario);
                        oUsuario.idUsuario = model.idUsuario;
                        oUsuario.nombre = model.nombre;
                        oUsuario.apellidos = model.apellidos;
                        oUsuario.correo = model.correo;
                        oUsuario.contraseña = model.contraseña;
                        oUsuario.fechaRegistro = model.fechaRegistro;
                        oUsuario.status = model.status;
                        oUsuario.idRol = model.idRol;
                        oUsuario.idCliente = model.idCliente;

                        db.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Usuario/");

                }
                return View(model);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpGet]
        public ActionResult Eliminar(int IdUsuario)
        {
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {

                var oUsuario = db.Usuario.Find(IdUsuario);
                oUsuario.status = false;
                db.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect("~/Usuario/");
        }

        [HttpGet]
        public ActionResult EliminarFisico(int IdUsuario)
        {
            using (ControlHrsConsultoriaEntities db = new ControlHrsConsultoriaEntities())
            {

                var oUsuario = db.Usuario.Find(IdUsuario);
                db.Usuario.Remove(oUsuario);
                db.SaveChanges();
            }
            return Redirect("~/Usuario/");
        }

    }
}