﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models
{
    [Table("COMPRACUBOS")]
    public class CompraCubos
    {
        [Key]
        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }
        [Column("ID_CUBO")]
        public int IdCubo { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("FECHAPEDIDO")]
        public DateTime FechaPedido { get; set; }
    }
}
