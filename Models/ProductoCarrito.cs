using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzadaG.Models
{
    public class ProductoCarrito
    {
        [Key]
        public int CodigoCarrito { get; set; }
        public int CodigoProducto { get; set; }
    }
}