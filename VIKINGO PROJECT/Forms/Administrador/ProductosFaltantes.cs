using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class ProductosFaltantes : Form
    {
        LProducto producto = new LProducto();
        public ProductosFaltantes()
        {
            InitializeComponent();
            cargarProductosFaltantes();
        }
        public void cargarProductosFaltantes()
        {
            producto.listarProductosFaltantes(DGV_Productos);
        }
    }
}
