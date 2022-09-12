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
    public partial class Menu_vendedor : Form
    {
        public Menu_vendedor()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            splitContainer2.IsSplitterFixed = true;
            LAdvertencia_NV.Text = "";
            LAdvertencia_NC.Text = "";
            LAdvertencia_C.Text = "";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BNuevaVenta_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_venta);

            if (frm == null)
            {
                Agregar_venta venta = new Agregar_venta();
                venta.TopLevel = false;
                venta.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(venta);
                splitContainer2.Panel2.Tag = venta;
                venta.BringToFront();
                venta.Show();
            }
            else
            {
                LAdvertencia_NV.Text = "*La ventana esta abierta";
                LAdvertencia_NV.ForeColor = Color.Red;
                
            }





            //Form formulario = splitContainer2.Panel2.Controls.OfType<T>().FirstOrDefault();
            //if ()
            //{

            //}

        }

        private void abrir_alta_cliente()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Alta_cliente);

            if (frm == null)
            {
                Alta_cliente cliente = new Alta_cliente();
                cliente.TopLevel = false;
                cliente.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(cliente);
                splitContainer2.Panel2.Tag = cliente;
                cliente.BringToFront();
                cliente.Show();

                
                
            }
            else
            {
                LAdvertencia_NC.Text = "*La ventana esta abierta";
                LAdvertencia_NC.ForeColor = Color.Red;

            }

            
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_alta_cliente();
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            abrir_alta_cliente();
        }

        private void BCerrar_sesion_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("¿Desea salir?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ask == DialogResult.Yes)
            {
                this.Close();
                //volver a inicio_sesion
                //inicio_Sesion inicio = new inicio_Sesion();

            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BConsulta_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta_producto);

            if (frm == null)
            {
                Consulta_producto consulta = new Consulta_producto();
                consulta.TopLevel = false;
                consulta.Dock = DockStyle.Fill; //que el form sea igual al panel
                splitContainer2.Panel2.Controls.Add(consulta);
                consulta.BringToFront();   
                consulta.Show();
            }
            else
            {
                LAdvertencia_C.Text = "*La ventana esta abierta";
                LAdvertencia_C.ForeColor = Color.Red;

            }
        }

        private void facturacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_facturaciones);

            if (frm == null)
            {
                Ver_facturaciones faturaciones = new Ver_facturaciones();
                faturaciones.TopLevel = false;
                faturaciones.Dock = DockStyle.Fill; //que el form sea igual al panel
                splitContainer2.Panel2.Controls.Add(faturaciones);
                faturaciones.BringToFront();
                faturaciones.Show();
            }
            else
            {
                MessageBox.Show("Ya esta abierto una ventana!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    

            }
        }
    }
}
