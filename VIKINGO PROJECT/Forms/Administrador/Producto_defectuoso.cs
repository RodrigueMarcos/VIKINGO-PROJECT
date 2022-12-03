using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Producto_defectuoso : Form
    {
        LProducto producto = new LProducto();
        int codigoProducto;
        int cantidadActual;
        public Producto_defectuoso()
        {
            InitializeComponent();
            listarProductos();
            cargarMotivo();

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (TBCantidad.Text != "")
            {
                DialogResult ask = MessageBox.Show("¿DESEA DAR DE BAJA A ESTE PRODUCTO?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ask == DialogResult.Yes && verificarCantidad())
                {
                    int cantidad = Convert.ToInt32(TBCantidad.Text);
                    if(producto.darDeBaja(codigoProducto,cantidad,CBMotivo.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Se registro correctamente el producto defectuoso", "Registro exitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarProductos();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error interno", "Error en la registración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                LAdvertencia.Text = "DEBES COMPLETAR TODOS LOS CAMPOS!!!";
            }
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

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress(sender, e);
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress(sender, e);
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void listarProductos()
        {
            producto.cargarListaProducto(DGV_productos);
        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoCodigo(TBCodigo.Text, DGV_productos);
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoNombre(TBNombre.Text, DGV_productos);
        }
        private void limpiarCampos()
        {
            TBCodigo.Clear();
            TBNombre.Clear();
            TBCantidad.Clear();
            LAdvertencia.Text = "";
            codigoProducto = 0;
            cantidadActual = 0;
        }
        private void cargarMotivo()
        {
            using(VIKINGO db = new VIKINGO())
            {
                CBMotivo.DataSource = (from m in db.Motivo select m).ToList();
                CBMotivo.DisplayMember = "descripcion";
                CBMotivo.ValueMember = "ID_motivo";
            }
        }

        private void DGV_productos_Click(object sender, EventArgs e)
        {
            codigoProducto = Convert.ToInt32(DGV_productos.CurrentRow.Cells["Codigo"].Value);
            TBProductoSel.Text = DGV_productos.CurrentRow.Cells["Nombre"].Value.ToString()
                +", "+ DGV_productos.CurrentRow.Cells["Descripcion"].Value.ToString();
            cantidadActual = Convert.ToInt32(DGV_productos.CurrentRow.Cells["Stock_actual"].Value);


        }
        private bool verificarCantidad()
        {
            if(Convert.ToInt32(TBCantidad.Text) <= cantidadActual)
            {
                return true;
            }
            else
            {
                LAdvertencia.Text = "La cantidad carga es mayor al stock actual del producto seleccionado";
                return false;
            }
        }
    }
}
