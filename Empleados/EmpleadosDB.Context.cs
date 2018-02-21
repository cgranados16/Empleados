﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Empleados
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmpleadosEntities : DbContext
    {
        public EmpleadosEntities()
            : base("name=EmpleadosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Correos> Correos { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Familiares> Familiares { get; set; }
        public virtual DbSet<HistorialVacaciones> HistorialVacaciones { get; set; }
        public virtual DbSet<PagosRealizados> PagosRealizados { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Telefonos> Telefonos { get; set; }
        public virtual DbSet<View_Empleado> View_Empleado { get; set; }
    
        public virtual int sp_PagoSalario(Nullable<int> idEmpleado, Nullable<decimal> monto, Nullable<System.DateTime> fecha)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("Monto", monto) :
                new ObjectParameter("Monto", typeof(decimal));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_PagoSalario", idEmpleadoParameter, montoParameter, fechaParameter);
        }
    }
}
