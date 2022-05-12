using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Domain.Entidades_Negocio;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        NAlumno _dalumno= new NAlumno();
        NEstado _destado= new NEstado();
        NEstatus _status= new NEstatus();
        NItemISR _itemISR= new NItemISR();
        // GET: Alumnos
        public ActionResult Index()
        {
            List<Alumno> alumnoList = _dalumno.Consultar();
            return View(alumnoList);
        }
        public ActionResult Details(int id)
        {
            Alumno alumn=_dalumno.Consultar(id);
            return View(alumn);
        }
        [HttpPost]
        public ActionResult Delete(int id) 
        {
            Alumno alumn = _dalumno.Consultar(id);
            return View(alumn); 
        }
        [HttpPost]
        public ActionResult Create()
        {
            List<Estado> lstEstados = _destado.Consultar();
            ViewBag.estados = lstEstados;
            List<EstatusAlumnos> lstEstatus = _status.Consultar();
            ViewBag.estatus = lstEstatus;
            return View();
        }
        //[HttpPost]
        public ActionResult Edit(int id)
        {
            Alumno alumn = _dalumno.Consultar(id);
            List<Estado> lstEstados = _destado.Consultar();
            ViewBag.estados = lstEstados;
            List<EstatusAlumnos> lstEstatus = _status.Consultar();
            ViewBag.estatus = lstEstatus;
            return View(alumn);
        }
        public ActionResult EliminaAlumno(int id)
        {
            _dalumno.Eliminar(id);
            return RedirectToAction("Index");
        }
        public ActionResult AgregarAlumno(Alumno model)
        {
            _dalumno.Agregar(model);
            return RedirectToAction("Index");
        }
        public ActionResult EditarAlumno(Alumno model)
        {
            _dalumno.Actualizar(model);
            return RedirectToAction("Index");
        }
        public ActionResult CalcularISR(int id)
        {
           ItemISR item= _itemISR.CalcularISR(id);
            return PartialView(item);
        }
    }
}