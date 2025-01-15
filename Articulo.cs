using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public string nombreArticulo { get; set; }
        public int cantidadArticulo { get; set; }
        public DateBoldEventArgs fechaAdquiArticulo { get; set; }
        public DateBoldEventArgs fechaVenciArticulo { get; set; }
        public string descripcionArticulo { get; set; }
        public int idTipoArticulo { get; set; }
        public string UnidadMedidaArticulo { get; set; }

        public Articulo() { }

        public Articulo(int idCliente, string nombreCliente, string telefonoCliente, string direccionCliente)
        {
            this.idArticulo = idArticulo;
            this.nombreArticulo = nombreArticulo;
            this.cantidadArticulo = cantidadArticulo;
            this.fechaAdquiArticulo = fechaAdquiArticulo;
            this.fechaVenciArticulo = fechaVenciArticulo;
            this.descripcionArticulo = descripcionArticulo;
            this.idTipoArticulo = idTipoArticulo;
            this.UnidadMedidaArticulo = UnidadMedidaArticulo;
        }
    }
}
