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
    public partial class Agregar_categoria : Form
    {
        public Agregar_categoria()
        {
            InitializeComponent();
            LAdvertencia.Text = ""; 
        }
        private LProducto producto = new LProducto();

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if(TBCategoria.Text != "")
            {
                DialogResult ask = MessageBox.Show("Desea agregar la categoria " + TBCategoria.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ask == DialogResult.Yes)
                {
                    LAdvertencia.Text = "";
                    if (producto.agregarCategoria(TBCategoria.Text))
                    {
                        MessageBox.Show("Se ingreso correctamente la Categoria: " + TBCategoria.Text, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TBCategoria.Clear();
                    }
                    else
                    {
                        MessageBox.Show("HUBO UN ERROR AL INGRESAR LA CATEGORIA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            else
            {
                LAdvertencia.Text = "DEBE INGRESAR UN NOMBRE PARA LA CATEGORIA";

            }
            

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}
