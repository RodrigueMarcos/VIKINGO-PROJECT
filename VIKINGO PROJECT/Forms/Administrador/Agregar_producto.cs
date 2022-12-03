using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.Forms.Administrador;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Agregar_producto : Form
    {
        private string nombreCategoria { get; set; }
        private int idCategoria { get; set; }
        private string nombreMarca { get; set; }
        private int idMarca { get; set; }

        public Agregar_producto()
        {
            InitializeComponent();
            cargar_MenuCategoria();
            cargar_MenuMarca();
            cargarListaProducto();
            LAdvertencia.Text = "";
        }

        

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if(verificar_campos_completos() && verificarCodigo() && verificar_precio())
            {
                DialogResult ask = MessageBox.Show("¿Desea agregar el producto a la base de datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ask == DialogResult.Yes)
                {
                    LProducto producto = new LProducto();
                    int codigo = Convert.ToInt32(TBCodigo.Text);
                    int cantidad = Convert.ToInt32(TBCantidad.Text);
                    decimal precio = Convert.ToDecimal(TBPrecio.Text);
                    int stockMin = Convert.ToInt32(TBStockMin.Text);
                    int idCategoria = Convert.ToInt32(CBCategoria.SelectedValue);
                    int idMarca = Convert.ToInt32(CBMarca.SelectedValue);
                    if (producto.agregarProducto(codigo, TBNombre.Text, TBDescripcion.Text, idCategoria, idMarca, stockMin, cantidad, precio))
                    {
                        MessageBox.Show("SE INGRESO CORRECTAMENTE EL PRODUCTO: "+codigo,"EXITOSO INGRESO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        producto.cargarListaProducto(DGVProducto);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("HUBO UN ERROR AL AGREGAR EL PRODUCTO.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                       
                 }
                   
                    
             }
        }
           
        
        private bool verificar_campos_completos()
        {
            if (TBCodigo.Text != "" && TBNombre.Text != "" && TBDescripcion.Text != ""
                && CBMarca.Text != "" && TBStockMin.Text != "" && CBCategoria.Text != ""&&TBCantidad.Text!=""&&TBPrecio.Text!="")
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
            TBCantidad.Clear();
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

            }else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS O EL CARACTER COMA";

            }
        }

        private bool verificar_precio()
        {
            char[] array = TBPrecio.Text.ToCharArray();
            int count = 0;
            for(int i = 0; i < TBPrecio.Text.Length; i++){
                if (array[i].Equals(',')) 
                {
                    count++;
                }
            }
            
            if(count <= 1)
            {
                Console.WriteLine(count);
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                Console.WriteLine(count);
                LAdvertencia.Text = "SE DETECTO EL INGRESO DE MAS DE UN . PARA EL DECIMAL";
                return false;
            }
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

        private void cargarListaProducto()
        {
            LProducto producto = new LProducto();
            producto.cargarListaProducto(DGVProducto);
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BRecargarMar_Click(object sender, EventArgs e)
        {
            cargar_MenuMarca();
        }

        private void BRecargarCat_Click(object sender, EventArgs e)
        {
            cargar_MenuCategoria();
        }
        private bool verificarCodigo()
        {
            int codigo = Convert.ToInt32(TBCodigo.Text);
           for(var i = 0; i < DGVProducto.Rows.Count; i++)
            {
                if(codigo == Convert.ToInt32(DGVProducto.Rows[i].Cells[0].Value))
                {
                    LAdvertencia.Text = "EL CÓDIGO INGRESADO ESTA SIENDO OCUPADO POR OTRO PRODUCTO";
                    return false;
                } 
            }
            return true;
        }
    }
}

