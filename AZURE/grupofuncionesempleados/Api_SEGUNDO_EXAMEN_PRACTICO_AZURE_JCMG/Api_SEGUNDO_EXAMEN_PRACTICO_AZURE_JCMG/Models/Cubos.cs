﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models
{
    [Table("CUBOS")]
    public class Cubos
    {
        [Key]
        [Column("ID_CUBO")]
        public int IdCubo { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("MARCA")]
        public string Marca { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
        [Column("PRECIO")]
        public int Precio { get; set; }
    }
}
