namespace ServicioWebAutorizacionPermisos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permisos")]
    public partial class Permisos
    {
       
        public int? Id { get; set; }

        public int? IdEmpleado { get; set; }

        [StringLength(22)]
        public string FechaSalida { get; set; }
        [StringLength(22)]
        public string FechaSalidaReal { get; set; }
        [StringLength(13)]
        public string HoraSalida { get; set; }
        [StringLength(13)]
        public string HoraSalidaReal { get; set; }
        public string FechaRegreso { get; set; }
        [StringLength(22)]
        public string FechaRegresoReal { get; set; }
        [StringLength(13)]
        public string HoraRegreso { get; set; }
        [StringLength(13)]
        public string HoraRegresoReal { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int? IdEstado { get; set; }

        public int? Numero { get; set; }

        [StringLength(20)]
        public string TipoPermiso { get; set; }
        [StringLength(50)]
        public string Motivo { get; set; }
        [StringLength(100)]
        public string JefeInmediato { get; set; }
        [StringLength(10)]
        public string TipoNomina { get; set; }
        [StringLength(15)]
        public string FechaPermiso { get; set; }
    }
}
