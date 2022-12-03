using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Listar_clientes : Form
    {
        LCliente cliente=new LCliente();
        public int dni;
        public string apellido;
        public string nombre;
        public int id_personaCliente;
        public Listar_clientes()
        {
            InitializeComponent();
            listarClientes();
            LApeyNombre.Text = "";
            LDni.Text = "";
        }

        private void listarClientes()
        {
            cliente.cargarClientesHabilitados(DGV_clientes);
        }

        private void DGV_clientes_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (dni != 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                LAdvertencia.Text = "NO SELECCIONASTE NINGUN CLIENTE";
            }
        }

        private void TBDni_KeyUp(object sender, KeyEventArgs e)
        {
            cliente.buscar_cliente_dni(TBDni.Text, DGV_clientes);
        }

        private void TBApellido_KeyUp(object sender, KeyEventArgs e)
        {
            cliente.buscar_cliente_apellido(TBApellido.Text, DGV_clientes);
        }

        private void DGV_clientes_Click(object sender, EventArgs e)
        {
            LAdvertencia.Text = "";
            dni = Convert.ToInt32(DGV_clientes.CurrentRow.Cells["DNI"].Value);
            apellido = DGV_clientes.CurrentRow.Cells["Apellido"].Value.ToString();
            nombre = DGV_clientes.CurrentRow.Cells["Nombre"].Value.ToString();
            id_personaCliente = Convert.ToInt32(DGV_clientes.CurrentRow.Cells["ID_persona"].Value);

            LDni.Text = Convert.ToString(dni);
            LApeyNombre.Text = apellido + ", " + nombre;
        }
    }
}
