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
    
    public partial class EmpleadosDB : DbContext
    {
        public EmpleadosDB()
            : base("name=EmpleadosDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Correo> Correos { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Familiare> Familiares { get; set; }
        public virtual DbSet<HistorialVacacione> HistorialVacaciones { get; set; }
        public virtual DbSet<PagosRealizado> PagosRealizados { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Telefono> Telefonos { get; set; }
    }
}