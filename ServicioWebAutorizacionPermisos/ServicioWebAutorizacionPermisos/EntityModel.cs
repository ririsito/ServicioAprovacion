namespace ServicioWebAutorizacionPermisos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<EmpleadoTurno> EmpleadoTurno { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpleadoTurno>()
                .Property(e => e.EmpleadoTurnoId)
                .IsUnicode(false);

            modelBuilder.Entity<EmpleadoTurno>()
                .Property(e => e.TurnoId)
                .IsUnicode(false);

            modelBuilder.Entity<EmpleadoTurno>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmpleadoTurno>()
                .Property(e => e.Registro)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.IdKardex)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.HoraEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.HoraSalida)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.TipoEmp)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.IDEstadoAsis)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Retardo)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.HorasTotales)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<Kardex>()
                .Property(e => e.TiempoExtra)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.TipoPermiso)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.JefeInmediato)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.TipoNomina)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.FechaPermiso)
                .IsUnicode(false);
        }
    }
}
