using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Agregar_usuario : Form
    {
        private int id_localidad;
        private string nombreProvincia;
        private string nombreLocalidad;
        public Agregar_usuario()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            cargarMenuGenero();
            cargarMenuTipoUser();
            
        }

       

        private void BSalir_Click(object sender, EventArgs e)
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
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)|| char.IsSeparator(e.KeyChar))
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

        private void LAgregar_ciudad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agregar_provincia provincia = new Agregar_provincia();
            if(provincia.ShowDialog() == DialogResult.OK)
            {
                id_localidad = provincia.id_localidad;
                nombreLocalidad = provincia.nombreLocalidad;
                nombreProvincia = provincia.nombreProvincia;
                TBProvincia.Text = nombreProvincia + ", " + nombreLocalidad;
            }
            
            
        }

        private void BAgregar__usuario_Click(object sender, EventArgs e)
        {
            if (verificar_camposCompletos()&&verificar_email()&& verificar_fechaNac()&&verificar_tamanoDNI()&&validar_password())
            {
                    DialogResult ask = MessageBox.Show("¿DESEA AGREGAR AL USUARIO: "+TBApellido.Text+" ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(ask == DialogResult.Yes)
                    {
                    LUsuario user = new LUsuario();
                    int dni = Convert.ToInt32(TBDni.Text);
                    long contacto = Convert.ToInt64(TBContacto.Text);
                    
                    int genero = Convert.ToInt32(CBGenero.SelectedValue);
                    string id_tipoUser = Convert.ToString(CBTipoUser.SelectedValue);

                    if (user.agregar_usuario(dni,TBApellido.Text,TBNombre.Text,contacto,TBEmail.Text,
                            id_localidad, TBDireccion.Text, genero, DTFechaNac.Value, TBUsuario.Text, TBPassword.Text, id_tipoUser)){

                        MessageBox.Show("Usuario: "+TBApellido.Text+" "+TBNombre.Text, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error interno al agregar al usuario: " + TBApellido.Text + " " + TBNombre.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    }
                
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

        public bool verificar_fechaNac()
        {
            if(DTFechaNac.Value < DateTime.Now) {
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                LAdvertencia.Text = "*DEBES INGRESAR UNA FECHA MENOR A LA DE HOY!!!";
                return false;
            }
        }
        private bool validar_password()
        {
            if (TBPassword.Text == TBRepPassword.Text)
            {
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                LAdvertencia.Text = "LA CONTRASEÑA NO SE INGRESO CORRECTAMENTE DOS VECES!!!";
                return false;   
            }
        }
        private bool verificar_tamanoDNI()
        {
            if(Convert.ToInt64(TBDni.Text) < 2147483647)
            {
                LAdvertencia.Text = "";
                return true;
            }
            else
            {
                LAdvertencia.Text = "*EN DNI NO SE ACEPTAN VALORES MAYOR A 2147483647";
                return false;
            }
        }

        private bool verificar_camposCompletos()
        {
            if(TBDni.Text!=""&&TBApellido.Text!=""&&TBNombre.Text!=""
                    &&TBContacto.Text!=""&&TBEmail.Text!=""&&DTFechaNac.Text!=""
                    &&TBProvincia.Text!=""&&TBDireccion.Text!=""&&TBUsuario.Text!=""&&TBPassword.Text!=""
                    &&TBRepPassword.Text!=""&& CBGenero.Text != ""){
                LAdvertencia.Text = "";
                return true;
            }else
            {
                LAdvertencia.Text = "COMPLETE TODOS LOS CAMPOS!!!";
                return false;
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

            TBNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text);
            TBNombre.SelectionStart = TBNombre.Text.Length;
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            TBApellido.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellido.Text);
            TBApellido.SelectionStart = TBApellido.Text.Length;
        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {
            TBDireccion.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBDireccion.Text);
            TBDireccion.SelectionStart = TBDireccion.Text.Length;
        }

        private void cargarMenuGenero()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var consulta = (from g in db.Genero select g).ToList();
                CBGenero.DataSource = consulta;
                CBGenero.DisplayMember = "descripcion";
                CBGenero.ValueMember = "ID_genero";
            }
        }
        private void cargarMenuTipoUser()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var consulta = (from g in db.Tipo_usuario select g).ToList();
                CBTipoUser.DataSource = consulta;
                CBTipoUser.DisplayMember = "descripcion";
                CBTipoUser.ValueMember = "ID_tipoUsuario";
            }
        }
        private void limpiarCampos()
        {
            TBDni.Clear();
            TBNombre.Clear();
            TBApellido.Clear();
            TBEmail.Clear();
            TBContacto.Clear();
            TBProvincia.Clear();
            id_localidad = 0;
            TBDireccion.Clear();
            TBUsuario.Clear();
            TBPassword.Clear();
            TBRepPassword.Clear();
        }
    }
}
