using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Forms.Vendedor;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Menu_administrador : Form
    {
        public Menu_administrador()
        {
            InitializeComponent();
            Ladvertencia_AU.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir_form_nuevo_usuario();
            
        }

        private void BCerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_ventas);

            if (frm == null)
            {
                Ver_ventas ventas = new Ver_ventas();
                ventas.TopLevel = false;
                ventas.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(ventas);
                splitContainer2.Panel2.Tag = ventas;
                ventas.BringToFront();
                ventas.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene un formulario abierto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Estadisticas);

            if (frm == null)
            {
                Estadisticas ventas = new Estadisticas();
                ventas.TopLevel = false;
                ventas.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(ventas);
                splitContainer2.Panel2.Tag = ventas;
                ventas.BringToFront();
                ventas.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene un formulario abierto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tablaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_empleados);

            if (frm == null)
            {
                Ver_empleados empleados = new Ver_empleados();
                empleados.TopLevel = false;
                empleados.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(empleados);
                splitContainer2.Panel2.Tag = empleados;
                empleados.BringToFront();
                empleados.Show();
            }
            else
            {
                MessageBox.Show("Ya esta abierto una ventana!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form_nuevo_usuario();
        }

        private void abrir_form_nuevo_usuario()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_usuario);
            if (frm == null)
            {
                Agregar_usuario usuario = new Agregar_usuario();
                usuario.TopLevel = false;
                usuario.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(usuario);
                usuario.BringToFront();
                usuario.Show();
            }
            else
            {
                Ladvertencia_AU.Text = "*La ventana esta abierta";
                Ladvertencia_AU.ForeColor = Color.Red;
            }
        }
    }
}
