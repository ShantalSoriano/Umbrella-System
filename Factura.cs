using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
        public class Factura
        {
            public int IdFactura { get; set; }
            public DateTime FechaFactura { get; set; }
            public decimal TotalFactura { get; set; }
            public int IdCliente { get; set; }

            public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

            public void CalcularTotal()
            {
                TotalFactura = Detalles.Sum(d => d.SubtotalDetalle);
            }
        }

        public class DetalleFactura
        {
            public int IdDetalle { get; set; }
            public int IdFactura { get; set; }
            public int IdServicio { get; set; }
            public int CantidadDetalle { get; set; }
            public decimal SubtotalDetalle { get; set; }
        }

    
}
