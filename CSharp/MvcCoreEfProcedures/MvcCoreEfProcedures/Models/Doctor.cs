using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreEfProcedures.Models
{
    [Table("DOCTOR")]
    public class Doctor
    {
        [Key]

        [Column("HOSPITAL_COD")]
        public string HospitalCod { get; set; }

        [Column("DOCTOR_NO")]
        public string DoctorNo { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("ESPECIALIDAD")]
        public string Especialidad { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
