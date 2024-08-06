using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzadaG.Models
{
    public class ProductoPedido
    {
        [Key] 
        public int CodigoPedido { get; set; }
        public int CodigoProducto { get; set; }
    }
}