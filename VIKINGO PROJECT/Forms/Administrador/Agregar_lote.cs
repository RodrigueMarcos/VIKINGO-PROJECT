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
using VIKINGO_PROJECT.logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Agregar_lote : Form
    {
        LProducto producto = new LProducto();
        LLote lote = new LLote();
        int id_producto;
        public Agregar_lote()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            listarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LAdvertencia_Click(object sender, EventArgs e)
        {

        }

        private void BAgregar_Click(object sender, EventArgs e)
        {

            if (TBCantidad.Text != "" && TBProductoSelec.Text!="") {
                int cantidad = Convert.ToInt32(TBCantidad.Text);
                if(cantidad > 0)
                {
                    DialogResult ask = MessageBox.Show("¿Deseas ingresar el lote?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        LAdvertencia.Text = "";
                        if (lote.agregarLote(id_producto, Convert.ToInt32(TBCantidad.Text)))
                        {
                            MessageBox.Show("Se registro correctamente el lote.", "Registro exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listarProductos();
                            limpiar_campos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error interno. Intentelo de nuevo. Si persiste el error contactese con el administrador", "Error de registración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                }
                else
                {
                    LAdvertencia.Text = "LA CANTIDAD NO PUEDE SER 0";
                }
                
            }
            else
            {
                LAdvertencia.Text = "DEBES SELECCIONAR UN PRODUCTO DE LA LISTA";
            }
        }

        private void limpiar_campos()
        {
            TBCodigo.Clear();
            TBNombre.Clear();   
            TBCantidad.Clear();
            LAdvertencia.Text = "";
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void solo_numerico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void solo_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR CARACTERES DE A-Z";

            }
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress(sender,e);
        }
        
        

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress(sender, e);
        }

        private void listarProductos()
        {
            producto.cargarListaProducto(DGV_Productos);
        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoCodigo(TBCodigo.Text, DGV_Productos);
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoNombre(TBCodigo.Text, DGV_Productos);
        }

        private void DGV_Productos_Click(object sender, EventArgs e)
        {
            id_producto = Convert.ToInt32(DGV_Productos.CurrentRow.Cells["Codigo"].Value);
            TBProductoSelec.Text = DGV_Productos.CurrentRow.Cells["Nombre"].Value.ToString() + ", " +
                DGV_Productos.CurrentRow.Cells["Descripcion"].Value.ToString() + ", " +
                DGV_Productos.CurrentRow.Cells["Categoria_des"].Value.ToString();

        }
    }
}
