using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzadaG.Models
{
    public class Carrito
    {
        [Key]
        public int CodigoCarrito { get; set; }
        public int CodigoUsuario { get; set; }
    }
}