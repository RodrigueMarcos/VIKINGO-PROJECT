using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGO_PROJECT.CDatos;

namespace VIKINGO_PROJECT.logica
{
    internal class LLote
    {
        
        public bool agregarLote(int id_producto, int p_cantidad)
        {
            Lote lote = new Lote();
            CDLote cdlote = new CDLote();

            lote.id_producto = id_producto;
            lote.cantidad = p_cantidad;
            lote.fecha_ingreso = DateTime.Now;
            return cdlote.insertarLote(lote);
        }
    }
}
