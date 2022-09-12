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

namespace VIKINGO_PROJECT.Forms.Supervisor
{
    public partial class Menu_supervisor : Form
    {
        public Menu_supervisor()
        {
            InitializeComponent();
            LAdvertencia_AP.Text = "";
            LAdvertencia_NI.Text = "";
            LAdvertencia_PC.Text = "";
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
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_lote);

            if(frm == null)
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
                LAdvertencia_NI.Text = "*La venta esta abierta";
                LAdvertencia_NI.ForeColor = Color.Red;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BVencimiento_Click(object sender, EventArgs e)
        {
            ver_productos_a_vencer();
        }

        private void productoAVencerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ver_productos_a_vencer()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_vencimientos);

            if (frm == null)
            {
                Ver_vencimientos vencimientos = new Ver_vencimientos();
                vencimientos.TopLevel = false;
                vencimientos.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(vencimientos);
                splitContainer2.Panel2.Tag = vencimientos;
                vencimientos.BringToFront();
                vencimientos.Show();
            }
            else
            {
                LAdvertencia_PC.Text = "*La ventana esta abierta";
                LAdvertencia_PC.ForeColor = Color.Red;

            }
        }

        private void modificarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_producto();
        }

        private void agregar_producto()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_producto);

            if (frm == null)
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
                LAdvertencia_AP.Text = "*La venta esta abierta";
                LAdvertencia_AP.ForeColor = Color.Red;
            }
        }

        private void productoDefectuosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver_productos_a_vencer();
        }

        private void productoDefectuosoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Producto_defectuoso);

            if (frm == null)
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
                MessageBox.Show("Ya hay una ventana abierta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
