﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models
{
    [Table("USUARIOSCUBO")]
    public class UsuarioCubos
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PASS")]
        public string Pass { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
