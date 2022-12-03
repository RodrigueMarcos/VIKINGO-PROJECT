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

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Listar_productos : Form
    {
        public Listar_productos()
        {
            InitializeComponent();
            cargarLista();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarLista()
        {
            LProducto producto = new LProducto();
            producto.cargarListaProducto(DGVListaPro);
        }

        
    }
}
