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
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.Forms.Administrador;
using VIKINGO_PROJECT.Forms.Supervisor;
using VIKINGO_PROJECT.Forms.Vendedor;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT
{
    public partial class login : Form
    {
        LUsuario usuario = new LUsuario();
        public login()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
        }

        private void BSesion_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string password = TBPassword.Text;

            if (usuario != "" && password != "")
            {
                    using (VIKINGO db = new VIKINGO())
                    {
                        try
                        {
                            var consulta = (from u in db.Usuario
                                            join p in db.Persona on u.id_persona equals p.ID_persona
                                            where u.usuario1 == usuario && u.contraseña == password
                                            select new UsuarioLogin
                                            {
                                                apellido = p.apellido,
                                                nombre = p.nombre,
                                                id_vendedor = p.ID_persona,
                                                tipo_usuario = u.tipo_usuario,
                                                estado = p.id_estado
                                            }).ToList().First();
                            
                                if (consulta.estado == "H")//estado H es habilitado y D no habilitado
                                {
                                    if (consulta.tipo_usuario == "V")
                                    {
                                        Menu_vendedor menu_v = new Menu_vendedor(consulta.nombre, consulta.apellido, consulta.id_vendedor);
                                        this.Hide();
                                        menu_v.ShowDialog();
                                        this.Show();
                                    }
                                    if (consulta.tipo_usuario == "A")
                                    {
                                        Menu_administrador menu_a = new Menu_administrador(consulta.apellido, consulta.nombre);
                                        this.Hide();
                                        menu_a.ShowDialog();
                                        this.Show();
                                    }
                                    if (consulta.tipo_usuario == "S")
                                    {
                                        Menu_SuperAdmin menu_a = new Menu_SuperAdmin();
                                        this.Hide();
                                        menu_a.ShowDialog();
                                        this.Show();
                                    }
                        }
                                else
                                {
                                    LAdvertencia.Text = "¡Usuario desabilitado!. Contáctese con la administración";
                                }
                           
                            
                            
                        } catch(Exception){
                            MessageBox.Show("¡No se encontro registrado ningun usuario con esa combinación de Clave y Contraseña!", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    
            }
            else
            {
                LAdvertencia.Text = "Debes ingresar el usuario y contraseña!!!";
            }
            
           
        }
        private bool verificar_campos_no_vacios()
        {
            if(TBUsuario.Text != "" && TBPassword.Text != "")
            {
                return true;
            }
            else
            {
              return false; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LAdvertencia_Click(object sender, EventArgs e)
        {

        }

       
    }
}
