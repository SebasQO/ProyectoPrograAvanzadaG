using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProyectoPrograAvanzadaG.Models
{
    public class DashboardViewModel
    {
        public int TotalUsuarios { get; set; }
        public int TotalProductos { get; set; }
        public int TotalClientes { get; set; }
        public int TotalPedidosRecientes { get; set; }
        public int TotalReseñasPendientes { get; set; }
    }
}
