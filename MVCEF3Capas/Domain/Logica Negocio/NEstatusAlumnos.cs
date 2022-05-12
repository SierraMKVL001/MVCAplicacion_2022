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
    public class NEstatusAlumnos
    {
        InstitutoTichEntities _DBContext=new InstitutoTichEntities();
        public List<EstatusAlumnos> Consultar()
        {
            List<EstatusAlumnos> _estatus=_DBContext.EstatusAlumnos.ToList();
            return _estatus;
        }
        public EstatusAlumnos Consultar(int id)
        {
            EstatusAlumnos _estatus = _DBContext.EstatusAlumnos.Find(id);
            return _estatus;
        }
        public void Agregar(EstatusAlumnos estta)
        {
            _DBContext.EstatusAlumnos.Add(estta);
            _DBContext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            EstatusAlumnos _estta = _DBContext.EstatusAlumnos.Find(id);
            _DBContext.EstatusAlumnos.Remove(_estta);
            _DBContext.SaveChanges();
        }
        public void Actualizar(EstatusAlumnos alum)
        {
            _DBContext.Entry(alum).State = EntityState.Modified;
            _DBContext.SaveChanges();
        }
    }
}
