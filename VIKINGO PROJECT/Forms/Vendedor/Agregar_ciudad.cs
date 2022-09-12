using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Agregar_ciudad : Form
    {
        public Agregar_ciudad()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //agregar ciudad
            if (TBDescripcion.Text != "" && TBLocalidad.Text != "" && TBProvincia.Text != "")
            {
                MessageBox.Show("Se ingreso correctamente");
            }
        }

        private void solo_letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        
    }
}
