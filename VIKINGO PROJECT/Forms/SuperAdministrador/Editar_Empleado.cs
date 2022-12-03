using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Editar_Empleado : Form
    {
        LUsuario usuario = new LUsuario();
        private string nombre_localidad;
        private string nombre_provincia;
        private int id_localidad;
        private DateTime fecha_ingreso;
        private string estado;
        private int id_usuario;
        private int id_persona;
        public Editar_Empleado()
        {
            InitializeComponent();
            cargarListaEmpleados();
            cargarMenuGenero();
            cargarMenuTipoUser();
            
        }

        

        private bool verificar_camposCompletos()
        {
            if (TBBuscarDni.Text != "" && TBDni.Text != "" && TBBuscarApellido.Text != "" && TBNombre.Text != ""
                    && TBContacto.Text != "" && TBEmail.Text != "" && DTFechaNac.Text != ""
                    && TBProvincia.Text != "" && TBDireccion.Text != "" && DTFechaIngreso.Text != ""
                    && TBUsuario.Text != "" && TBPassword.Text != "" && TBRepPassword.Text != ""
                    && CBGenero.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
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
        private void cargarListaEmpleados()
        {
            usuario.cargarDataGridView(DGV_Usuarios);
        }

        private void DGV_Usuarios_DoubleClick(object sender, EventArgs e)
        {
            TBDni.Text = DGV_Usuarios.CurrentRow.Cells["DNI"].
                            Value.ToString();
            TBApellido.Text = DGV_Usuarios.CurrentRow.Cells["Apellido"].
                            Value.ToString();
            TBNombre.Text = DGV_Usuarios.CurrentRow.Cells["Nombre"].
                            Value.ToString();
            TBContacto.Text = DGV_Usuarios.CurrentRow.Cells["Contacto"].
                            Value.ToString();
            TBEmail.Text = DGV_Usuarios.CurrentRow.Cells["Email"].
                            Value.ToString();
            TBDireccion.Text = DGV_Usuarios.CurrentRow.Cells["Domicilio"].
                            Value.ToString();
            CBGenero.Text = DGV_Usuarios.CurrentRow.Cells["Genero"].
                            Value.ToString();
            CBTipoUser.Text = DGV_Usuarios.CurrentRow.Cells["Tipo_Usuario"].
                            Value.ToString();
            nombre_localidad = DGV_Usuarios.CurrentRow.Cells["Ciudad"].
                            Value.ToString();
            nombre_provincia = DGV_Usuarios.CurrentRow.Cells["Localidad"].
                            Value.ToString();
            TBProvincia.Text = nombre_provincia + ", " + nombre_localidad;
            id_localidad = Convert.ToInt32(DGV_Usuarios.CurrentRow.Cells["ID_localidad"].
                            Value);
            fecha_ingreso = Convert.ToDateTime(DGV_Usuarios.CurrentRow.Cells["Fecha_DeIngreso"].Value);
            DTFechaIngreso.Value = fecha_ingreso;

            DTFechaNac.Value = Convert.ToDateTime(DGV_Usuarios.CurrentRow.Cells["Fecha_DeNacimiento"].Value);
            TBUsuario.Text = DGV_Usuarios.CurrentRow.Cells["Usuario"].
                            Value.ToString();
            TBPassword.Text = DGV_Usuarios.CurrentRow.Cells["Password"].
                            Value.ToString();
            TBRepPassword.Text = DGV_Usuarios.CurrentRow.Cells["Password"].
                            Value.ToString();
            estado = DGV_Usuarios.CurrentRow.Cells["id_estado"].Value.ToString();
            id_usuario = Convert.ToInt32(DGV_Usuarios.CurrentRow.Cells["ID_usuario"].Value);
            id_persona = Convert.ToInt32(DGV_Usuarios.CurrentRow.Cells["id_persona"].Value);


            if (estado == "H")
            {
                CBActivo.Checked = true;
                CBActivo.Text = "Habilitado";
            }
            else
            {
                CBActivo.Checked = false;
                CBActivo.Text = "Deshabilitado";
            }
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
                var consulta = (from t in db.Tipo_usuario select t).ToList();
                CBTipoUser.DataSource = consulta;
                CBTipoUser.DisplayMember = "descripcion";
                CBTipoUser.ValueMember = "ID_tipoUsuario";
            }
        }

        private void LLModificar_Click(object sender, EventArgs e)
        {
            Agregar_provincia ciudad = new Agregar_provincia();
            if (ciudad.ShowDialog() == DialogResult.OK)
            {
                nombre_provincia = ciudad.nombreProvincia;
                nombre_localidad = ciudad.nombreLocalidad;
                id_localidad = ciudad.id_localidad;
                TBProvincia.Text = nombre_provincia + ", " + nombre_localidad;

            }
        }

        private void TBBuscarApellido_KeyUp(object sender, KeyEventArgs e)
        {
            usuario.buscarPorApellido(TBBuscarApellido.Text, DGV_Usuarios);
        }

        private void TBBuscarCUIL_KeyUp(object sender, KeyEventArgs e)
        {
            usuario.buscarPorDni(TBBuscarDni.Text, DGV_Usuarios);
        }

        private void BModificar_Click_1(object sender, EventArgs e)
        {
            if (verificar_campos_completos() && verificar_tamanoDNI() && verificar_email())
            {
                DialogResult ask = MessageBox.Show("¿Desea modificar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    LUsuario user = new LUsuario();
                    int dni = Convert.ToInt32(TBDni.Text);
                    int genero = Convert.ToInt32(CBGenero.SelectedValue);
                    string tipoUSer = Convert.ToString(CBTipoUser.SelectedValue);
                    long contacto = Convert.ToInt64(TBContacto.Text);
                    
                    if (user.actulizarUsuario(id_usuario,id_persona, dni, TBApellido.Text, TBNombre.Text, contacto,
                        TBEmail.Text, id_localidad, TBDireccion.Text, genero, estado, DTFechaNac.Value,
                        fecha_ingreso, TBUsuario.Text, TBPassword.Text, tipoUSer))
                    {
                        MessageBox.Show("Se modifico correntamente al usuario: "+TBApellido.Text,"Operación exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cargarListaEmpleados();
                        limpiar_campos();

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error interno durante la operación","Operación fallida",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool verificar_campos_completos()
        {
            if (TBApellido.Text != "" && TBNombre.Text != "" && TBContacto.Text != "" && TBEmail.Text != ""
                && TBDni.Text != "" && TBProvincia.Text != "" && TBDireccion.Text != ""
                && TBUsuario.Text != "" && TBPassword.Text!=""&&TBRepPassword.Text!="")
            {
                return true;
            }
            else
            {
                LAdvertencia.Text = "*DEBES COMPLETAR TODOS LOS DATOS";
                return false;
            }
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

       
        private void limpiar_campos()
        {
            TBBuscarDni.Clear();
            TBBuscarApellido.Clear();
            TBApellido.Clear();
            TBNombre.Clear();
            TBDni.Clear();
            TBContacto.Clear();
            TBEmail.Clear();
            TBProvincia.Clear();
            TBDireccion.Clear();
            DTFechaIngreso.Value = DateTime.Now;
            DTFechaNac.Value = DateTime.Now;
            TBUsuario.Clear();
            TBPassword.Clear();
            TBRepPassword.Clear();
            CBActivo.Checked = false;
            CBActivo.Text = "";
        }

        private void CBActivo_Click(object sender, EventArgs e)
        {
            if (CBActivo.Checked == true)
            {
                estado = "H";
                CBActivo.Text = "Habilitado";
            }
            else
            {
                estado = "D";
                CBActivo.Text = "Deshabilitado";
            }
        }
    }
}
