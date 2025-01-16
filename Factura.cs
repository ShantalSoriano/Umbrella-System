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

            // Constructor opcional
            public Factura(int idFactura, DateTime fechaFactura, decimal totalFactura, int idCliente)
            {
                IdFactura = idFactura;
                FechaFactura = fechaFactura;
                TotalFactura = totalFactura;
                IdCliente = idCliente;
            }

            public Factura() { } // Constructor por defecto
        }

    
}
