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
    public partial class Alta_cliente : Form
    {
        
        public Alta_cliente()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            cargarMenuGenero();
            cargarMenuTipoCliente();
         
            TBCiudad.ReadOnly = true;
            cargarDataGridView();
                

        }

        private string nombre_provincia;
        private string nombre_localidad;
        private int id_localidad;
        
        //crea el objeto donde esta toda la logica para crear subObjetos  e insertar en BD 
        LCliente objLCliente = new LCliente();
        private void TBDni_TextChanged(object sender, EventArgs e)
        {

        }

        private bool verficar_campos_completos()
        {
            if (TBApellido.Text != ""&& TBNombre.Text != ""&& TBContacto.Text != ""&& TBEmail.Text != ""&& TBDni.Text != ""&& TBCiudad.Text != ""&& TBDireccion.Text != ""&& CBGenero.Text != ""&& CBTipo.Text != "")
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
            if (char.IsLetter(e.KeyChar)|| char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
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
         
                Agregar_provincia ciudad = new Agregar_provincia();
                if(ciudad.ShowDialog() == DialogResult.OK)
                {
                    nombre_provincia = ciudad.nombreProvincia;
                    nombre_localidad = ciudad.nombreLocalidad;
                    id_localidad = ciudad.idlocalidad;
                    TBCiudad.Text = nombre_provincia+", "+nombre_localidad;
                    
                }
                //ciudad.TopLevel = true;
                //ciudad.Dock = DockStyle.Fill;
                //splitContainer2.Panel2.Controls.Add(ciudad);
                //splitContainer2.Panel2.Tag = ciudad;
                //ciudad.BringToFront();
                //ciudad.Show();
           
        }

        

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //verificar si estan todos los campos cargados
            if (verificar_campos_completos() && verificar_tamanoDNI() && verificar_email())
            {

                
                    //confirmar guardar
                    DialogResult ask = MessageBox.Show("¿Desea agregar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ask == DialogResult.Yes)
                    {
                        //converciones
                        int dni = Convert.ToInt32(TBDni.Text);
                        long contacto = Convert.ToInt64(TBContacto.Text);
                        int genero = Convert.ToInt32(CBGenero.SelectedValue);
                        int tipo = Convert.ToInt32(CBTipo.SelectedValue);
                       
                        
                   
                        if (objLCliente.agregarCliente(dni, TBApellido.Text, TBNombre.Text,
                            contacto, TBEmail.Text, id_localidad, TBDireccion.Text, genero, tipo))
                        {
                            MessageBox.Show("Se ingreso correctamente al cliente " + TBApellido.Text + " " + TBNombre.Text,
                                "Ingreso exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDataGridView();
                            limpiar_campos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error interno al agregar " + TBApellido.Text + " " + TBNombre.Text,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }




                
            }
            
           

        }

        private bool verificar_campos_completos()
        {
            if(TBApellido.Text!=""&&TBNombre.Text!=""&&TBContacto.Text!=""&&TBEmail.Text!=""
                &&TBDni.Text!=""&&TBCiudad.Text!=""&&TBDireccion.Text!=""
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
            
        }

        private bool verificar_tamanoDNI()
        {
            if(Convert.ToInt64(TBDni.Text) < 2147483647)
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
            if(new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(TBEmail.Text))
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

        private void cargarMenuGenero()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listaGenero = (from g in db.Genero select g).ToList();
                CBGenero.DataSource = listaGenero;
                CBGenero.DisplayMember = "descripcion";
                CBGenero.ValueMember = "ID_genero";
            }
        }
        private void cargarMenuTipoCliente()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listaTipo = (from t in db.Tipo_cliente select t).ToList();
                CBTipo.DataSource = listaTipo;
                CBTipo.DisplayMember = "descripcion";
                CBTipo.ValueMember = "ID_tipoCliente";
            }
        }








    }
}
