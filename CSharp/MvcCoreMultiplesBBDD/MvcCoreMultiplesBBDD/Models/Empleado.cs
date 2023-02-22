using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreMultiplesBBDD.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]

        [Column("EMP_NO")]
        public int EmpNo { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("OFICIO")]
        public string Oficio { get; set; }

        [Column("FECHA_ALT")]
        public DateTime FechaAlt { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
