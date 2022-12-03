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

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Agregar_provincia : Form
    {
        public int id_localidad = -1;
        public string nombreProvincia;
        public string nombreLocalidad;
        public Agregar_provincia()
        {
            InitializeComponent();
            cargarProvincia();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                

        /*private void BGuardar_Click(object sender, EventArgs e)
        {
            //validación
            if (TBLocalidad.Text != "" && TBProvincia.Text != "")
            {
                //llama a la capa logica
                LCiudad datos = new LCiudad();
                if (datos.agregar_provincia(TBProvincia.Text))
                {
                    MessageBox.Show("Ingreso exitos!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                LAdvertencia.Text = "Debes completar todos los campos!!!";
            }
        }*/
        private void cargarProvincia()
        {
            using (VIKINGO db = new VIKINGO())
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
            using (VIKINGO db = new VIKINGO())
            {
                var listaLocalidad = (from loc in db.Localidad where loc.id_provincia == id_pro select loc).ToList();
                CBLocalidad.DataSource = listaLocalidad;
                CBLocalidad.DisplayMember = "Nombre";
                CBLocalidad.ValueMember = "ID_localidad";
            }
        }

     
        private void CBLocalidad_TextChanged(object sender, EventArgs e)
        {
            nombreLocalidad = CBLocalidad.Text;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if(id_localidad != -1){
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CBLocalidad_Click(object sender, EventArgs e)
        {
            id_localidad = Convert.ToInt32(CBLocalidad.SelectedValue);
        }

        private void CBProvincia_Click(object sender, EventArgs e)
        {
            cargar_localidad();
            nombreProvincia = CBProvincia.Text;
        }

        private void CBProvincia_TextChanged_1(object sender, EventArgs e)
        {
            cargar_localidad();
            nombreProvincia = CBProvincia.Text;
        }
    }
}
