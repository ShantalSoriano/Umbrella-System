using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class PrefServicios
    {
        public int idCliente { get; set; }
        public int idServicio { get; set; }
        public PrefServicios() { }
        public PrefServicios(int idCliente, int idServicio)
        {
            this.idCliente = idCliente;
            this.idServicio = idServicio;
        }
    }
}
