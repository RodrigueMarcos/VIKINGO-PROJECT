using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.Forms.Supervisor;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Ver_productos : Form
    {
        public int codigo;
        public string nombre;
        public int cantidad;
        public decimal precio;
        public string descripcion;
        LProducto producto = new LProducto();
        public Ver_productos()
        {
            InitializeComponent();
            cargarListaProducto();
            LAdvertencia.Text = "";
            LNombrePro.Text = "";
            LCodigoPro.Text = "";
            PProductoSelec.Visible = false;
            /*LProductoSec.Visible = false;
            LCodigoSelec.Visible = false;
            LCodigoPro.Visible = false;
            LNombreSelec.Visible = false;
            LNombrePro.Visible = false;
            BAgregar.Visible = false;*/
        }
        public Ver_productos(string p_seleccionar)
        {
            InitializeComponent();
            cargarListaProducto();
            LAdvertencia.Text = "";
            LNombrePro.Text = "";
            LCodigoPro.Text = "";
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(TBCodigo.Text != "" && TBNombre.Text != "")
            {
                //buscar
            }
            else
            {
                MessageBox.Show("Debes ingresar el código o nombre del producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void cargarListaProducto()
        {
            
            producto.cargarListaProducto(DGVProducto);
        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoCodigo(TBCodigo.Text, DGVProducto);
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoNombre(TBNombre.Text, DGVProducto);
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (codigo != 0 && nombre != "")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                LAdvertencia.Text = "DEBES SELECCIONAR UN PRODUCTO DE LA LISTA";
            }

        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS";

            }
        }

        private void DGVProducto_Click(object sender, EventArgs e)
        {
            LAdvertencia.Text = "";
            codigo = Convert.ToInt32(DGVProducto.CurrentRow.Cells["Codigo"].Value);
            nombre = DGVProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            precio = Convert.ToDecimal(DGVProducto.CurrentRow.Cells["Precio"].Value);
            cantidad = Convert.ToInt32(DGVProducto.CurrentRow.Cells["Stock_actual"].Value);
            descripcion = DGVProducto.CurrentRow.Cells["Descripcion"].Value.ToString();

            LCodigoPro.Text = Convert.ToString(codigo);
            LNombrePro.Text = nombre;
        }
    }
}
