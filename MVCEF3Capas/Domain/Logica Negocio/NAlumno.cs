using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataAccess;
using System.Data.Entity;

namespace Domain.Logica_Negocio
{
    public class NAlumno
    {
        private InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        public List<Alumnos> Consultar()
        {
            _DBContext.Configuration.LazyLoadingEnabled = false;
            List<Alumnos> consultar =_DBContext.Alumnos.ToList();
            return consultar;
        }
        public Alumnos Consultar(int id)
        {
            Alumnos consultar = _DBContext.Alumnos.Find(id);
            return consultar;
        }
        public void Agregar(Alumnos alumn)
        {
            _DBContext.Alumnos.Add(alumn);
            _DBContext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Alumnos _alumno=_DBContext.Alumnos.Find(id);
            _DBContext.Alumnos.Remove(_alumno);
            _DBContext.SaveChanges();
        }
        public void Actualizar(Alumnos alum)
        {
            _DBContext.Entry(alum).State = EntityState.Modified;
            _DBContext.SaveChanges();
        }
    }
}
