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
    public class NEstados
    {
        private InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        public List<Estados> Consultar()
        {
            List<Estados> lista = _DBContext.Estados.ToList();
            return lista;
        }
        public Estados Consultar(int id)
        {
           Estados _estado= _DBContext.Estados.Find(id);
            return _estado;
        }
        public void Agregar(Estados edo)
        {
            _DBContext.Estados.Add(edo);
            _DBContext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Estados _alumno = _DBContext.Estados.Find(id);
            _DBContext.Estados.Remove(_alumno);
            _DBContext.SaveChanges();
        }
        public void Actualizar(Estados alum)
        {
            _DBContext.Entry(alum).State = EntityState.Modified;
            _DBContext.SaveChanges();
        }
    }
}
