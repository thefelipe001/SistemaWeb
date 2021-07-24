namespace Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Departamento")]
    public partial class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }

        [StringLength(50)]
        public string NombreDepartamento { get; set; }
    }
}
