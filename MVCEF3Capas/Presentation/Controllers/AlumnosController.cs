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
        public ActionResult Create(Models.ViewModels.AlumnoViewModel alum)
        {
            try
            {
                Alumnos _Alumno = new Alumnos();
                if (ModelState.IsValid)
                {
                    _Alumno.id = alum.id;
                    _Alumno.nombre = alum.nombre;
                    _Alumno.primerApellido = alum.primerApellido;
                    _Alumno.segundoApellido = alum.segundoApellido;
                    _Alumno.curp = alum.curp;
                    _Alumno.fechaNacimiento = alum.fechaNacimiento;
                    _Alumno.correo = alum.correo;
                    _Alumno.telefono = alum.telefono;
                    _Alumno.sueldoMensual = alum.sueldoMensual;
                    _Alumno.idEstadoOrigen = alum.idEstadoOrigen;
                    _Alumno.idEstatus = alum.idEstatus;
                    _nAlumno.Agregar(_Alumno);
                    return RedirectToAction("Index");
                }
                List<Estados> lstEstados = _nestados.Consultar();
                ViewBag.estados = lstEstados;
                List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
                ViewBag.estatus = lstEstatus;
                return View();
            }
            catch
            {
                List<Estados> lstEstados = _nestados.Consultar();
                ViewBag.estados = lstEstados;
                List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
                ViewBag.estatus = lstEstatus;
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
        public ActionResult Edit(int id, Models.ViewModels.AlumnoViewModel alum)
        {
            try
            {
                Alumnos _Alumno = new Alumnos();
                if (ModelState.IsValid)
                {
                    _Alumno.id = alum.id;
                    _Alumno.nombre = alum.nombre;
                    _Alumno.primerApellido = alum.primerApellido;
                    _Alumno.segundoApellido = alum.segundoApellido;
                    _Alumno.curp = alum.curp;
                    _Alumno.fechaNacimiento = alum.fechaNacimiento;
                    _Alumno.correo = alum.correo;
                    _Alumno.telefono = alum.telefono;
                    _Alumno.sueldoMensual = alum.sueldoMensual;
                    _Alumno.idEstadoOrigen = alum.idEstadoOrigen;
                    _Alumno.idEstatus = alum.idEstatus;
                    _nAlumno.Actualizar(_Alumno);
                    return RedirectToAction("Index");
                }
                Alumnos alumn = _nAlumno.Consultar(id);
                List<Estados> lstEstados = _nestados.Consultar();
                ViewBag.estados = lstEstados;
                List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
                ViewBag.estatus = lstEstatus;
                return View(alumn);
                // TODO: Add update logic here

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
                Alumnos alumn = _nAlumno.Consultar(id);
                List<Estados> lstEstados = _nestados.Consultar();
                ViewBag.estados = lstEstados;
                List<EstatusAlumnos> lstEstatus = _nestatusAlumnos.Consultar();
                ViewBag.estatus = lstEstatus;
                return View(alumn);
            }
        }
        public ActionResult _AportacionesIMSS(int id)
        {
            AportacionesIMSS _IMSS=_nAlumno.CalcularIMSS(id);
            return PartialView(_IMSS);
        }
        public ActionResult _TablaISR(int id)
        {
            ItemISR _item = _nAlumno.CalcularISR(id);
            return PartialView(_item);
        }
    }
}
