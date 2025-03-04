﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceWCFLogicaClientes.Model
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ImagenCliente { get; set; }
    }
}