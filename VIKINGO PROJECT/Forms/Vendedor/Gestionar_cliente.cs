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

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Gestionar_cliente : Form
    {
        private string nombre_provincia;
        private string nombre_localidad;
        private int id_localidad;
        private DateTime fecha_ingreso;
        private int id_cliente;
        private string estado;
        private int id_persona;
        //crea el objeto donde esta toda la logica para crear subObjetos  e insertar en BD 
        LCliente objLCliente = new LCliente();
        public Gestionar_cliente()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            CBGenero.Items.Add("Femenino");
            CBGenero.Items.Add("Masculino");
            CBGenero.Items.Add("Otro");
            CBTipo.Items.Add("Mayorista");
            CBTipo.Items.Add("Minorista");
            TBCiudad.ReadOnly = true;
            cargarDataGridView();
        }


        

        private void BActualizar_Click(object sender, EventArgs e)
        {
            if (verificar_campos_completos() && verificar_tamanoDNI() && verificar_email())
            {
                DialogResult ask = MessageBox.Show("¿Desea modificar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    LCliente cliente = new LCliente();
                    int dni = Convert.ToInt32(TBDni.Text);
                    int genero = CBGenero.Items.IndexOf(CBGenero.Text) + 1;
                    int tipo = CBTipo.Items.IndexOf(CBTipo.Text) + 1;
                    long contacto = Convert.ToInt64(TBContacto.Text);
                    
                    if (cliente.actualizar_persona(id_persona, dni, TBApellido.Text, TBNombre.Text, contacto,
                        TBEmail.Text, id_localidad, TBDireccion.Text, genero, tipo, fecha_ingreso, id_cliente, estado))
                    {
                        MessageBox.Show("Se registro correctamente las modificaciones","Actualización exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cargarDataGridView();
                        limpiar_campos();
                       
                    }
                    else
                    {
                        MessageBox.Show("hubo un error");
                    }
                }
            }
        }

        private void limpiar_campos()
        {
            TBDni.Text = "";
            TBApellido.Text = "";
            TBNombre.Text = "";
            TBContacto.Text = "";
            TBEmail.Text = "";
            TBCiudad.Text = "";
            TBDireccion.Text = "";
            LAdvertencia.Text = "";
            nombre_provincia = "";
            nombre_localidad = "";
            id_localidad = 0;
            id_cliente = 0;
            id_persona = 0;
        }
        private bool verficar_campos_completos()
        {
            if (TBApellido.Text != "" && TBNombre.Text != "" && TBContacto.Text != "" && TBEmail.Text != "" && TBDni.Text != "" && TBCiudad.Text != "" && TBDireccion.Text != "" && CBGenero.Text != "" && CBTipo.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void solo_numerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS";

            }
        }

        private void solo_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR CARACTERES DE A-Z";

            }
        }

        private void agregar_ciudad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregar_provincia);

            if (frm == null)
            {
                Agregar_provincia ciudad = new Agregar_provincia();
                if (ciudad.ShowDialog() == DialogResult.OK)
                {
                    nombre_provincia = ciudad.nombreProvincia;
                    nombre_localidad = ciudad.nombreLocalidad;
                    id_localidad = ciudad.idlocalidad;
                    TBCiudad.Text = nombre_provincia + ", " + nombre_localidad;

                }
                //ciudad.TopLevel = true;
                //ciudad.Dock = DockStyle.Fill;
                //splitContainer2.Panel2.Controls.Add(ciudad);
                //splitContainer2.Panel2.Tag = ciudad;
                //ciudad.BringToFront();
                //ciudad.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene una ventana abierta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private bool verificar_campos_completos()
        {
            if (TBApellido.Text != "" && TBNombre.Text != "" && TBContacto.Text != "" && TBEmail.Text != ""
                && TBDni.Text != "" && TBCiudad.Text != "" && TBDireccion.Text != ""
                && CBGenero.Text != "" && CBTipo.Text != "")
            {
                return true;
            }
            else
            {
                LAdvertencia.Text = "*DEBES COMPLETAR TODOS LOS DATOS";
                return false;
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            TBApellido.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellido.Text);
            TBApellido.SelectionStart = TBApellido.Text.Length;
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            TBNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text);
            TBNombre.SelectionStart = TBNombre.Text.Length;
        }
        private bool verificar_tamanoDNI()
        {
            if (Convert.ToInt64(TBDni.Text) < 2147483647)
            {
                return true;
            }
            else
            {
                LAdvertencia.Text = "*EN DNI NO SE ACEPTAN VALORES MAYOR A 2147483647";
                return false;
            }
        }
        public bool verificar_email()
        {
            if (new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(TBEmail.Text))
            {
                return true;
            }
            else
            {
                LAdvertencia.Text = "*NO SE RECONOCE EL EMAIL(DEBE CONTENER SOLO UN . Y @)";
                return false;
            }
        }
        public void cargarDataGridView()
        {
            LCliente cliente = new LCliente();
            cliente.cargarClientesHabilitados(DGClientes);


        }

        private void DGClientes_DoubleClick(object sender, EventArgs e)
        {
            id_cliente = Convert.ToInt32(DGClientes.CurrentRow.Cells["ID_cliente"].Value);
            TBDni.Text = DGClientes.CurrentRow.Cells["Dni"].
                            Value.ToString();
            TBApellido.Text = DGClientes.CurrentRow.Cells["Apellido"].
                            Value.ToString();
            TBNombre.Text = DGClientes.CurrentRow.Cells["Nombre"].
                            Value.ToString();
            TBContacto.Text = DGClientes.CurrentRow.Cells["Contacto"].
                            Value.ToString();
            TBEmail.Text = DGClientes.CurrentRow.Cells["Email"].
                            Value.ToString();
            TBDireccion.Text = DGClientes.CurrentRow.Cells["Domicilio"].
                            Value.ToString();
            CBGenero.Text = DGClientes.CurrentRow.Cells["Genero"].
                            Value.ToString();
            CBTipo.Text = DGClientes.CurrentRow.Cells["Tipo"].
                            Value.ToString();
            nombre_localidad = DGClientes.CurrentRow.Cells["Ciudad"].
                            Value.ToString();
            nombre_provincia = DGClientes.CurrentRow.Cells["Localidad"].
                            Value.ToString();
            TBCiudad.Text = nombre_provincia + ", " + nombre_localidad;
            id_localidad = Convert.ToInt32(DGClientes.CurrentRow.Cells["ID_localidad"].
                            Value);
            fecha_ingreso = Convert.ToDateTime(DGClientes.CurrentRow.Cells["Fecha_DeIngreso"].Value.ToString());
            estado = DGClientes.CurrentRow.Cells["id_estado"].Value.ToString();
            id_persona = Convert.ToInt32(DGClientes.CurrentRow.Cells["ID_persona"].Value);

        }

       

       

        private void TBBuscadorApe_KeyUp(object sender, KeyEventArgs e)
        {
            objLCliente.buscar_cliente_apellido(TBBuscadorApe.Text, DGClientes);
        }

        private void TBBuscadorNom_KeyUp(object sender, KeyEventArgs e)
        {
            objLCliente.buscar_cliente_nombre(TBBuscadorNom.Text, DGClientes);
        }

        
        private void TBBuscar_KeyUp(object sender, KeyEventArgs e)
        {
                objLCliente.buscar_cliente_dni(TBBuscar.Text, DGClientes);
            
        }


        private void BCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregar_ciudad_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
