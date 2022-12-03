using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGO_PROJECT.Entidad
{
    internal class FacturaCompleta
    {
        public int ID_Factura { get; set; }
        public int Dni { get; set; }
        public string Cliente {get; set;}
        public string Vendedor { get; set; }
        public string Tipo_Factura { get; set; }
        public string Forma_De_Pago { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
