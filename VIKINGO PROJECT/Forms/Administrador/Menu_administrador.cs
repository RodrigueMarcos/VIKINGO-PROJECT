using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Forms.Administrador;
using VIKINGO_PROJECT.Forms.Vendedor;

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Menu_administrador : Form
    {
        private string apellido;
        private string nombre;
        public Menu_administrador(string p_apellido, string p_nombre)
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            apellido = p_apellido;
            nombre = p_nombre;
            LApeNom.Text = apellido + ", " + nombre;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar_producto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (verificar_form_abiertos()==false)
            {
                Agregar_lote ingreso = new Agregar_lote();
                ingreso.TopLevel = false;
                ingreso.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(ingreso);
                ingreso.BringToFront();
                ingreso.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("¿Desea salir?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                this.Close();
                

            }
        }

        private void BVencimiento_Click(object sender, EventArgs e)
        {
            ver_productos_a_vencer();
        }

        private void productoAVencerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Modificar_producto form = new Modificar_producto();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(form);
                splitContainer2.Panel2.Tag = form;
                form.BringToFront();
                form.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
            }
        }

        private void ver_productos_a_vencer()
        {
            

            if (verificar_form_abiertos()==false)
            {
                Listar_productos vencimientos = new Listar_productos();
                vencimientos.TopLevel = false;
                vencimientos.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(vencimientos);
                splitContainer2.Panel2.Tag = vencimientos;
                vencimientos.BringToFront();
                vencimientos.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA!!!";
                

            }
        }

        private void modificarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_producto();
        }

        private void agregar_producto()
        {
            

            if (verificar_form_abiertos()==false)
            {
                Agregar_producto producto = new Agregar_producto();
                producto.TopLevel = false;
                producto.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(producto);
                producto.BringToFront();
                producto.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
                
            }
        }

        private void productoDefectuosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver_productos_a_vencer();
        }

        private void productoDefectuosoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            if (verificar_form_abiertos()==false)
            {
                Producto_defectuoso producto = new Producto_defectuoso();
                producto.TopLevel = false;
                producto.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(producto);
                producto.BringToFront();
                producto.Show();
            }
            else
            {
                MessageBox.Show("*HAY UNA VENTANA ABIERTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        

        private bool verificar_form_abiertos()
        {
            Form frm1 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Producto_defectuoso);
            Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_producto);
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Listar_productos);
            Form frm4 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_lote);
            Form frm5 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_ventas);
            Form frm6 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Estadistica);
            Form frm7 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_producto);
            Form frm8 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ProductosFaltantes);
            Form frm9 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GestionarCliente);
            if (frm1 == null && frm2 == null && frm3 == null && frm4 == null && frm5 == null && frm6 == null&&frm7==null&&frm8==null&&frm9==null)
            {
                LAdvertencia.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
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
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
            }
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Estadistica ventas = new Estadistica();
                ventas.TopLevel = false;
                ventas.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(ventas);
                splitContainer2.Panel2.Tag = ventas;
                ventas.BringToFront();
                ventas.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
            calc.WaitForExit();
        }

        private void productosFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            if (verificar_form_abiertos() == false)
            {
                ProductosFaltantes form = new ProductosFaltantes();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(form);
                splitContainer2.Panel2.Tag = form;
                form.BringToFront();
                form.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
            }
        }

        private void BGestionarCli_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                GestionarCliente form = new GestionarCliente();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(form);
                splitContainer2.Panel2.Tag = form;
                form.BringToFront();
                form.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
            }
        }
    }
}
