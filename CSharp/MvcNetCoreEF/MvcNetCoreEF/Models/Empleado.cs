﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcNetCoreEF.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [Column("EMP_NO")]
        public int IdEmpleado { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("OFICIO")]
        public string Oficio { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
