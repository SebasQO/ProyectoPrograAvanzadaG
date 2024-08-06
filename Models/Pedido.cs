using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzadaG.Models
{
    public class Pedido
    {
        [Key]
        public int CodigoPedido { get; set; }
        public int CodigoUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}