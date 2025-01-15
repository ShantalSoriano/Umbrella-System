using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string nombreCliente, string telefonoCliente, string direccionCliente)
        {
            this.idCliente = idCliente;
            this.nombre = nombreCliente;
            this.telefono = telefonoCliente;
            this.direccion = direccionCliente;
        }
    }
}
