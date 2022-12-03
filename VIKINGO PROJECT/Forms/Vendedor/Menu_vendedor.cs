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
        private int idVendedor;
        private string nombreV;
        private string apellidoV;
        public Menu_vendedor(string p_nombre, string p_apellido, int p_id)
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            splitContainer2.IsSplitterFixed = true;
            LAdvertencia.Text = "";
            LAdvertencia.ForeColor = Color.Red;
            nombreV = p_nombre;
            apellidoV = p_apellido;
            Vendedor.Text = "Vendedor: "+ nombreV + ", " + apellidoV;
            idVendedor = p_id;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BNuevaVenta_Click(object sender, EventArgs e)
        {
            abrir_form_GestionarCliente();

        }

        private void abrir_alta_cliente()
        {
           
            if (verificar_form_abiertos()==false)
            {
                Alta_cliente cliente = new Alta_cliente();
                cliente.TopLevel = false;
                cliente.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(cliente);
                splitContainer2.Panel2.Tag = cliente;
                cliente.BringToFront();
                cliente.Show();
                LAdvertencia.Text = "";


            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
                

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
            if (verificar_form_abiertos() == false)
            {
                Agregar_venta venta = new Agregar_venta(nombreV, apellidoV, idVendedor);
                venta.TopLevel = false;
                venta.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(venta);
                splitContainer2.Panel2.Tag = venta;
                venta.BringToFront();
                venta.Show();
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";


            }
           

        }

        private void facturacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (verificar_form_abiertos()==false)
            {
                Ver_facturaciones faturaciones = new Ver_facturaciones(idVendedor);
                faturaciones.TopLevel = false;
                faturaciones.Dock = DockStyle.Fill; //que el form sea igual al panel
                splitContainer2.Panel2.Controls.Add(faturaciones);
                faturaciones.BringToFront();
                faturaciones.Show();
                LAdvertencia.Text = "";
            }
            else
            {
                MessageBox.Show("YA ESTA ABIERTO UNA VENTANA!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    

            }
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_verProducto();
        }

        private void form_verProducto()
        {
            
            if (verificar_form_abiertos() == false)
            {
                Ver_productos consulta = new Ver_productos();
                consulta.TopLevel = false;
                consulta.Dock = DockStyle.Fill; //que el form sea igual al panel
                splitContainer2.Panel2.Controls.Add(consulta);
                consulta.BringToFront();
                consulta.Show();
                LAdvertencia.Text = "";
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";
                

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private bool verificar_form_abiertos()
        {
            Form frm1= Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_facturaciones);
            Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Alta_cliente);
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_venta);
            Form frm4 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ver_productos);
            Form frm5 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Gestionar_cliente);

            if (frm1 == null && frm2 == null && frm3 == null && frm4==null&&frm5==null)
            {
                return false;
            }
            else
            {
                return true;//hay formularios abiertos
            }

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
            calc.WaitForExit(); 
        }
        private void BNuevaVenta_MouseLeave(object sender, EventArgs e)
        {
            BGestionarCliente.BackColor = Color.Navy;
        }
        private void BNuevaVenta_MouseHover(object sender, EventArgs e)
        {
            BGestionarCliente.BackColor = Color.Blue;
        }

        

        private void BConsulta_MouseLeave(object sender, EventArgs e)
        {
            BNuevaVenta.BackColor = Color.Navy;
        }

        private void BConsulta_MouseHover(object sender, EventArgs e)
        {
            BNuevaVenta.BackColor= Color.Blue;
        }

        private void BNuevoCliente_MouseHover(object sender, EventArgs e)
        {
            BNuevoCliente.BackColor = Color.Blue;
        }

        private void BNuevoCliente_MouseLeave(object sender, EventArgs e)
        {
            BNuevoCliente.BackColor = Color.Navy;
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificar_form_abiertos() == false)
            {
                Ver_productos productos = new Ver_productos();
                productos.TopLevel = false;
                productos.Dock = DockStyle.Fill; //que el form sea igual al panel
                splitContainer2.Panel2.Controls.Add(productos);
                productos.BringToFront();
                productos.Show();
                LAdvertencia.Text = "";
            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";


            }
        }

        private void Menu_vendedor_Load(object sender, EventArgs e)
        {
           
        }

        private void GestiorCliente_Click(object sender, EventArgs e)
        {
            form_verProducto();
            
        }

        private void gestionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form_GestionarCliente();
        }
        
        private void abrir_form_GestionarCliente()
        {
            if (verificar_form_abiertos() == false)
            {
                Gestionar_cliente cliente = new Gestionar_cliente();
                cliente.TopLevel = false;
                cliente.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(cliente);
                splitContainer2.Panel2.Tag = cliente;
                cliente.BringToFront();
                cliente.Show();
                LAdvertencia.Text = "";


            }
            else
            {
                LAdvertencia.Text = "*HAY UNA VENTANA ABIERTA";


            }
        }
    }
}
