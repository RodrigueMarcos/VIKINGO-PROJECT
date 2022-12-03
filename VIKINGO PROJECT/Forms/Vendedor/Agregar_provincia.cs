using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.logica;
using System.Data.SqlClient;

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Agregar_provincia : Form
    {
        
        public Agregar_provincia()
        {
            InitializeComponent();
            cargarProvincia();
            LAdvertencia.Text = "";
        }
        public string nombreProvincia{ get; set; }
        public string nombreLocalidad { get; set; }
        public int idlocalidad { get; set; }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //validación
            if (CBLocalidad.Text != "" && CBProvincia.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Close();
                //llama a la capa logica
                /*LCiudad datos = new LCiudad();
                if (datos.agregar_provincia(CBProvincia.Text))
                {
                    MessageBox.Show("Ingreso exitos!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                
            }
            else
            {
                LAdvertencia.Text = "Debes completar todos los campos!!!";
            }
        }

        private void solo_letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";
            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBE INGREGAR CARACTERES DE A-Z";
            }
        }

        

        private void cargarProvincia()
        {
            using(VIKINGO db = new VIKINGO())
            {
                var listaProvincia = (from pr in db.Provincia select pr).ToList();
                CBProvincia.DataSource = listaProvincia;
                CBProvincia.DisplayMember = "Nombre";
                CBProvincia.ValueMember = "ID_provincia";
            }
        }


        private void cargar_localidad()
        {
            int id_pro = Convert.ToInt32(CBProvincia.SelectedValue);
             using(VIKINGO db = new VIKINGO())
            {
                var listaLocalidad = (from loc in db.Localidad where loc.id_provincia == id_pro select loc).ToList();
                CBLocalidad.DataSource = listaLocalidad;
                CBLocalidad.DisplayMember = "Nombre";
                CBLocalidad.ValueMember = "ID_localidad";
            }
        }

        private void CBProvincia_TextChanged(object sender, EventArgs e)
        {
            cargar_localidad();
            nombreProvincia = CBProvincia.Text;
        }

        private void CBLocalidad_TextChanged(object sender, EventArgs e)
        {
            nombreLocalidad = CBLocalidad.Text;
        }

        private void CBLocalidad_Click(object sender, EventArgs e)
        {
            idlocalidad = Convert.ToInt32(CBLocalidad.SelectedValue);
            
        }
    }
}
