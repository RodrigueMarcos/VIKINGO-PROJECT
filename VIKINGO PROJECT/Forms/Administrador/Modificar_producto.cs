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

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Modificar_producto : Form
    {
        LProducto producto = new LProducto();
        int stockActual;
        public Modificar_producto()
        {
            InitializeComponent();
            ListarProductos();
            LAdvertencia.Text="";
            cargar_MenuCategoria();
            cargar_MenuMarca();
        }

        private void TBBuscarCod_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoCodigo(TBBuscarCod.Text, DGVListaProducto);
        }

        private void TBBuscarNom_KeyUp(object sender, KeyEventArgs e)
        {
            producto.buscarProductoNombre(TBBuscarNom.Text, DGVListaProducto);

        }
        private void ListarProductos()
        {
            producto.cargarListaProducto(DGVListaProducto);
        }
        private bool verificar_campos_completos()
        {
            if (TBCodigo.Text != "" && TBNombre.Text != "" && TBDescripcion.Text != ""
                && CBMarca.Text != "" && TBStockMin.Text != "" && CBCategoria.Text != "" && TBPrecio.Text != "")
            {
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                LAdvertencia.Text = "DEBES COMPLETAR TODOS LOS CAMPOS!!!";
                return false;
            }
        }
        private void limpiarCampos()
        {
            TBCodigo.Clear();
            TBNombre.Clear();
            TBDescripcion.Clear();
            
            TBStockMin.Clear();
            TBPrecio.Clear();
            stockActual = 0;
            
           
        }
        private void solo_numeros(object sender, KeyPressEventArgs e)
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




        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.Equals(','))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS O EL CARACTER COMA";

            }
        }
        private bool verificar_precio()
        {
            char[] array = TBPrecio.Text.ToCharArray();
            int count = 0;
            for (int i = 0; i < TBPrecio.Text.Length; i++)
            {
                if (array[i].Equals(','))
                {
                    count++;
                }
            }

            if (count <= 1)
            {
                Console.WriteLine(count);
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                Console.WriteLine(count);
                LAdvertencia.Text = "SE DETECTO EL INGRESO DE MAS DE UN .";
                return false;
            }
        }

        private void LLAgregarMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agregar_Marca marca = new Agregar_Marca();
            marca.TopLevel = true;
            marca.BringToFront();
            marca.Show();
        }

        private void LLCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agregar_categoria categoria = new Agregar_categoria();
            categoria.TopLevel = true;
            categoria.BringToFront();
            categoria.Show();
        }

        private void BRecargarMar_Click(object sender, EventArgs e)
        {

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (verificar_campos_completos() && verificar_precio())
            {
                DialogResult ask = MessageBox.Show("¿Deseas modificar el producto " + TBNombre.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(TBCodigo.Text);
                    int stockMin = Convert.ToInt32(TBStockMin.Text);
                    int idCategoria = Convert.ToInt32(CBCategoria.SelectedValue);
                    int idMarca = Convert.ToInt32(CBMarca.SelectedValue);
                    decimal precio = Convert.ToDecimal(TBPrecio.Text); 

                    if (producto.modificarProducto(codigo,TBNombre.Text,TBDescripcion.Text, idCategoria, idMarca, stockMin,stockActual,precio))
                    {
                        MessageBox.Show("SE MODIFICO CORRECTAMENTE EL PRODUCTO " + TBNombre.Text, "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        ListarProductos();
                    }
                    else
                    {
                        MessageBox.Show("HUBO UN ERROR INTERNO AL INTENTAR MODIFICAR EL PRODUCTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DGVListaProducto_DoubleClick(object sender, EventArgs e)
        {
            TBCodigo.Text = DGVListaProducto.CurrentRow.Cells["Codigo"].Value.ToString();
            TBNombre.Text = DGVListaProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            TBDescripcion.Text = DGVListaProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
            CBCategoria.Text = DGVListaProducto.CurrentRow.Cells["Categoria_des"].Value.ToString();
            CBMarca.Text = DGVListaProducto.CurrentRow.Cells["Marca_des"].Value.ToString();
            stockActual = Convert.ToInt32(DGVListaProducto.CurrentRow.Cells["Stock_actual"].Value);
            TBStockMin.Text = DGVListaProducto.CurrentRow.Cells["Stock_minimo"].Value.ToString();
            TBPrecio.Text = DGVListaProducto.CurrentRow.Cells["Precio"].Value.ToString();
        }
       
        
        private void cargar_MenuCategoria()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listarCategoria = (from cat in db.Categoria orderby cat.descripcion ascending select cat).ToList();
                CBCategoria.DataSource = listarCategoria;
                CBCategoria.DisplayMember = "descripcion";
                CBCategoria.ValueMember = "ID_categoria";
            }
        }
        private void cargar_MenuMarca()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listarMarca = (from mar in db.Marca orderby mar.descripcion ascending select mar).ToList();
                CBMarca.DataSource = listarMarca;
                CBMarca.DisplayMember = "descripcion";
                CBMarca.ValueMember = "ID_marca";
            }
        }
    }
}
