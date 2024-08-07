﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzadaG.Models
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public bool Disponibilidad { get; set; }
        public bool Estado { get; set; }
    }
}