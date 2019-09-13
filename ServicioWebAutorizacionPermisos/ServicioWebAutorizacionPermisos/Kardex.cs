namespace ServicioWebAutorizacionPermisos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kardex")]
    public partial class Kardex
    {
        [Key]
        [StringLength(25)]
        public string IdKardex { get; set; }

        public int? NumeroEmpleado { get; set; }

        [StringLength(15)]
        public string HoraEntrada { get; set; }

        [StringLength(15)]
        public string HoraSalida { get; set; }

        public int? IDClaseNomina { get; set; }

        [StringLength(15)]
        public string TipoEmp { get; set; }

        [StringLength(10)]
        public string IDEstadoAsis { get; set; }

        [StringLength(15)]
        public string Retardo { get; set; }

        [StringLength(15)]
        public string HorasTotales { get; set; }

        [StringLength(25)]
        public string Fecha { get; set; }

        [StringLength(15)]
        public string TiempoExtra { get; set; }
    }
}
