﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Minimarket_Raphi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Minimarket_RaphiEntities : DbContext
    {
        public Minimarket_RaphiEntities()
            : base("name=Minimarket_RaphiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agrega_Producto> Agrega_Producto { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<HistoricoProducto> HistoricoProducto { get; set; }
        public virtual DbSet<Hoja_de_Registro> Hoja_de_Registro { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<Kardex_SV> Kardex_SV { get; set; }
        public virtual DbSet<Operaciones_Producto> Operaciones_Producto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Registra> Registra { get; set; }
        public virtual DbSet<Registro_Producto> Registro_Producto { get; set; }
        public virtual DbSet<Subfamilia_Producto> Subfamilia_Producto { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
    }
}
