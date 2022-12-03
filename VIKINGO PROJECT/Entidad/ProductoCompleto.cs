using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGO_PROJECT.Entidad
{
    internal class ProductoCompleto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ID_categoria { get; set; }
        public string Categoria_des { get; set; }
        public int ID_Marca { get; set; }
        public string Marca_des { get; set; }
        public int Stock_actual { get; set; }
        public int Stock_minimo { get; set; }
        public decimal Precio { get; set; }
    }
}
