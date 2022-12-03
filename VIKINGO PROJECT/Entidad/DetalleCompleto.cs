using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGO_PROJECT.Entidad
{
    internal class DetalleCompleto
    {
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Sub_Total { get; set; }
    }
}
