namespace Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Direccion")]
    public partial class Direccion
    {
        [Key]
        public int IdDireccion { get; set; }

        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Calle { get; set; }

        [StringLength(50)]
        public string Provincia { get; set; }

        public int? ClienteId { get; set; }
    }
}
