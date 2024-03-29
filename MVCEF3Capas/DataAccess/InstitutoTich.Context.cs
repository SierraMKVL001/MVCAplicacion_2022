﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entidades;
    
    public partial class InstitutoTichEntities : DbContext
    {
        public InstitutoTichEntities()
            : base("name=InstitutoTichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstatusAlumnos> EstatusAlumnos { get; set; }
        public virtual DbSet<TablaISR> TablaISR { get; set; }
    
        public virtual int actualizarAlumnos(Nullable<int> iDed, string nombre, string primer, string segundo, string corr, string tel, Nullable<System.DateTime> fNac, string curp, Nullable<decimal> sMen, Nullable<int> idEO, Nullable<int> idES)
        {
            var iDedParameter = iDed.HasValue ?
                new ObjectParameter("IDed", iDed) :
                new ObjectParameter("IDed", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var primerParameter = primer != null ?
                new ObjectParameter("primer", primer) :
                new ObjectParameter("primer", typeof(string));
    
            var segundoParameter = segundo != null ?
                new ObjectParameter("segundo", segundo) :
                new ObjectParameter("segundo", typeof(string));
    
            var corrParameter = corr != null ?
                new ObjectParameter("corr", corr) :
                new ObjectParameter("corr", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("tel", tel) :
                new ObjectParameter("tel", typeof(string));
    
            var fNacParameter = fNac.HasValue ?
                new ObjectParameter("fNac", fNac) :
                new ObjectParameter("fNac", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("curp", curp) :
                new ObjectParameter("curp", typeof(string));
    
            var sMenParameter = sMen.HasValue ?
                new ObjectParameter("sMen", sMen) :
                new ObjectParameter("sMen", typeof(decimal));
    
            var idEOParameter = idEO.HasValue ?
                new ObjectParameter("idEO", idEO) :
                new ObjectParameter("idEO", typeof(int));
    
            var idESParameter = idES.HasValue ?
                new ObjectParameter("idES", idES) :
                new ObjectParameter("idES", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizarAlumnos", iDedParameter, nombreParameter, primerParameter, segundoParameter, corrParameter, telParameter, fNacParameter, curpParameter, sMenParameter, idEOParameter, idESParameter);
        }
    
        public virtual int agregarAlumnos(string nombre, string primer, string segundo, string corr, string tel, Nullable<System.DateTime> fNac, string curp, Nullable<decimal> sMen, Nullable<int> idEO, Nullable<int> idES)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var primerParameter = primer != null ?
                new ObjectParameter("primer", primer) :
                new ObjectParameter("primer", typeof(string));
    
            var segundoParameter = segundo != null ?
                new ObjectParameter("segundo", segundo) :
                new ObjectParameter("segundo", typeof(string));
    
            var corrParameter = corr != null ?
                new ObjectParameter("corr", corr) :
                new ObjectParameter("corr", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("tel", tel) :
                new ObjectParameter("tel", typeof(string));
    
            var fNacParameter = fNac.HasValue ?
                new ObjectParameter("fNac", fNac) :
                new ObjectParameter("fNac", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("curp", curp) :
                new ObjectParameter("curp", typeof(string));
    
            var sMenParameter = sMen.HasValue ?
                new ObjectParameter("sMen", sMen) :
                new ObjectParameter("sMen", typeof(decimal));
    
            var idEOParameter = idEO.HasValue ?
                new ObjectParameter("idEO", idEO) :
                new ObjectParameter("idEO", typeof(int));
    
            var idESParameter = idES.HasValue ?
                new ObjectParameter("idES", idES) :
                new ObjectParameter("idES", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("agregarAlumnos", nombreParameter, primerParameter, segundoParameter, corrParameter, telParameter, fNacParameter, curpParameter, sMenParameter, idEOParameter, idESParameter);
        }
    
        public virtual ObjectResult<consultasAlumnos_Result> consultasAlumnos(Nullable<int> idAlum)
        {
            var idAlumParameter = idAlum.HasValue ?
                new ObjectParameter("idAlum", idAlum) :
                new ObjectParameter("idAlum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultasAlumnos_Result>("consultasAlumnos", idAlumParameter);
        }
    
        public virtual int eliminarAlumnos(Nullable<int> idAl)
        {
            var idAlParameter = idAl.HasValue ?
                new ObjectParameter("idAl", idAl) :
                new ObjectParameter("idAl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminarAlumnos", idAlParameter);
        }
    }
}
