namespace ServicioWebAutorizacionPermisos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpleadoTurno")]
    public partial class EmpleadoTurno
    {
        [StringLength(20)]
        public string EmpleadoTurnoId { get; set; }

        public int? EmpleadoId { get; set; }

        [StringLength(15)]
        public string TurnoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(5)]
        public string Estatus { get; set; }

        [StringLength(10)]
        public string Registro { get; set; }
    }
}
