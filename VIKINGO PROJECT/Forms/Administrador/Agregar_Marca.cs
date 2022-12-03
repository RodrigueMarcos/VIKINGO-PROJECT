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
    public partial class Agregar_Marca : Form
    {
        public Agregar_Marca()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TBMarca.Text != "")
            {
                DialogResult ask = MessageBox.Show("Desea agregar la marca " + TBMarca.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ask == DialogResult.Yes)
                {
                    LProducto producto = new LProducto();
                    if (producto.agregarMarca(TBMarca.Text))
                    {
                        MessageBox.Show("SE INGRESO CORRECTAMENTE LA MARCA: " + TBMarca.Text, "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error interno al intentar agregar la marca!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                LAdvertencia.Text = "EL CAMPO NOMBRE ESTA VACIO!";
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
