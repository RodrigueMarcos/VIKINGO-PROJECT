using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Forms.SuperAdministrador;
using VIKINGO_PROJECT.Forms.Vendedor;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Menu_SuperAdmin : Form
    {
        public Menu_SuperAdmin()
        {
            InitializeComponent();
            Ladvertencia.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir_form_nuevo_usuario();
            
        }

        private void BCerrar_sesion_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("¿Desea salir?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
        }

        private void tablaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (verificar_form_abiertos()==false)
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
                Ladvertencia.Text = "*La ventana esta abierta";
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form_nuevo_usuario();
        }

        private void abrir_form_nuevo_usuario()
        {
           if (verificar_form_abiertos() == false)
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
                Ladvertencia.Text = "*La ventana esta abierta";
                
            }
        }

        private bool verificar_form_abiertos()
        {
            Form frm1 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_usuario);
            Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_empleados);
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Editar_Empleado);
            Form frm4 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Backup_form);
            Form frm5 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Restaurar_form);
            if (frm1==null&&frm2==null&&frm3==null&&frm4==null&&frm5==null)
            {
                Ladvertencia.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void usuaioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darBajaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Editar_Empleado usuario = new Editar_Empleado();
                usuario.TopLevel = false;
                usuario.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(usuario);
                usuario.BringToFront();
                usuario.Show();
            }
            else
            {
                Ladvertencia.Text = "*HAY UNA VENTANA ABIERTA";

            }
        }

        private void BBackup_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Backup_form form = new Backup_form();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            else
            {
                Ladvertencia.Text = "*HAY UNA VENTANA ABIERTA";

            }
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Restaurar_form form = new Restaurar_form();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(form);
                form.BringToFront();
                form.Show();
            }
            else
            {
                Ladvertencia.Text = "*HAY UNA VENTANA ABIERTA";

            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
            calc.WaitForExit();
        }
    }
    }

