using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Entity
{
    public partial class ApplicationDB : DbContext
    {
        public ApplicationDB()
            : base("name=ApplicationDB")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.NombreDepartamento)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Provincia)
                .IsUnicode(false);
        }
    }
}
