using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Domain.Logica_Negocio;

namespace Presentation.Controllers
{
    public class AlumnosController : Controller
    {
        NAlumno _nAlumno=new NAlumno();
        NEstados _nestados=new NEstados();
        NEstatusAlumnos _nestatusAlumnos=new NEstatusAlumnos();
        // GET: Alumnos
        public ActionResult Index()
        {
            List<Alumnos> alumnos = _nAlumno.Consultar();
            return View(alumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            Alumnos alumnos=_nAlumno.Consultar(id);
            return View(alumnos);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            List<Estados> lstEstados = _nestados.Consultar();
            ViewBag.estados = lstEstados;
            List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
            ViewBag.estatus = lstEstatus;
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            try
            {
                _nAlumno.Agregar(alum);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            Alumnos alumn = _nAlumno.Consultar(id);
            List<Estados> lstEstados = _nestados.Consultar();
            ViewBag.estados = lstEstados;
            List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
            ViewBag.estatus = lstEstatus;
            return View(alumn);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alum)
        {
            try
            {
                // TODO: Add update logic here
                _nAlumno.Actualizar(alum);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            Alumnos alumnos = _nAlumno.Consultar(id);
            return View(alumnos);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos collection)
        {
            try
            {
                // TODO: Add delete logic here
                _nAlumno.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
