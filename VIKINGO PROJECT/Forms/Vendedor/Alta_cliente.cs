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
    public partial class Alta_cliente : Form
    {
        public Alta_cliente()
        {
            InitializeComponent();

            CBGenero.Items.Add("Masculino");
            CBGenero.Items.Add("Femenino");
            CBGenero.Items.Add("Otro");
            CBTipo.Items.Add("Minorista");
            CBTipo.Items.Add("Mayorista");

        }

        private void LDireccion_Click(object sender, EventArgs e)
        {

        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {

        }

        private bool verficar_campos_completos()
        {
            if (TBApellido.Text != ""&& TBNombre.Text != ""&& TBContacto.Text != ""&& TBEmail.Text != ""&& TBDni.Text != ""&& TBCiudad.Text != ""&& TBDireccion.Text != ""&& CBGenero.Text != ""&& CBTipo.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta_cliente_Load(object sender, EventArgs e)
        {

        }

        

        private void solo_numerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void solo_letras_KeyPress(object sender, KeyPressEventArgs e)
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

        private void agregar_ciudad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_ciudad);

            if (frm == null)
            {
                Agregar_ciudad ciudad = new Agregar_ciudad();
                ciudad.TopLevel = true;
                ciudad.Dock = DockStyle.Fill;
                //splitContainer2.Panel2.Controls.Add(ciudad);
                //splitContainer2.Panel2.Tag = ciudad;
                ciudad.BringToFront();
                ciudad.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene una ventana abierta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
