using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.Forms.Administrador;
using VIKINGO_PROJECT.Forms.Vendedor;

namespace VIKINGO_PROJECT.logica
{
    internal class LUsuario
    {
        CDUsuario objUsuario = new CDUsuario();

        public bool agregar_usuario(int p_dni, string p_apellido, string p_nombre,
           long p_telefono, string p_email, int p_localidad, string p_direccion,
           int p_genero, DateTime p_fechaNac,
            string p_usuario, string p_password, string p_tipoUser)
        {
            //1er Crear el objeto persona
            Persona persona = new Persona();
            int idPersona = buscarIDPeronsaUltimo() + 1;
            persona.ID_persona = idPersona;
            persona.DNI = p_dni;
            persona.nombre = p_nombre;
            persona.apellido = p_apellido;
            persona.telefono = p_telefono;
            persona.email = p_email;
            persona.domicilio = p_direccion;
            persona.id_localidad = p_localidad;
            persona.id_genero = p_genero;
            persona.id_estado = "H"; //activo

            Usuario usuario = new Usuario();
            usuario.ID_usuario = buscarIdUltimo() + 1;
            usuario.id_persona = idPersona;
            usuario.fecha_ingreso = DateTime.Now;
            usuario.fecha_nacimiento = p_fechaNac;
            usuario.usuario1 = p_usuario;
            usuario.contraseña = p_password;
            usuario.tipo_usuario = p_tipoUser;

            return objUsuario.insertarUsuario(persona, usuario);
            
        }

        public bool actulizarUsuario(int p_idUsuario, int p_idPersona, int p_dni, string p_apellido, string p_nombre,
           long p_telefono, string p_email, int p_localidad, string p_direccion,
           int p_genero, string p_estado, DateTime p_fechaNac, DateTime p_fechaIngreso,
            string p_usuario, string p_password, string p_tipoUser)
        {
            //1er Crear el objeto persona
            Persona persona = new Persona();
            persona.DNI = p_dni;
            persona.nombre = p_nombre;
            persona.apellido = p_apellido;
            persona.telefono = p_telefono;
            persona.email = p_email;
            persona.domicilio = p_direccion;
            persona.id_localidad = p_localidad;
            persona.id_genero = p_genero;
            persona.id_estado = p_estado;
            persona.ID_persona = p_idPersona;

            Usuario usuario = new Usuario();
            usuario.ID_usuario = p_idUsuario;
            usuario.id_persona = p_idPersona;
            usuario.fecha_ingreso = p_fechaIngreso;
            usuario.fecha_nacimiento = p_fechaNac;
            usuario.usuario1 = p_usuario;
            usuario.contraseña = p_password;
            usuario.tipo_usuario = p_tipoUser;

            return objUsuario.actualizarUsuario(persona, usuario);
        }
        public void cargarDataGridView(DataGridView p_dgv)
        {
            p_dgv.DataSource = objUsuario.listarUsuarios();
            p_dgv.Columns["id_estado"].Visible = false;
            p_dgv.Columns["ID_localidad"].Visible = false;
            p_dgv.Columns["id_persona"].Visible = false;
            p_dgv.Columns["ID_usuario"].Visible = false;
            p_dgv.Columns["Usuario"].Visible = false;
            p_dgv.Columns["Password"].Visible = false;

        }

        public void buscarPorApellido(string p_apellido, DataGridView p_dgv)
        {
            p_dgv.DataSource = objUsuario.filtrarPorApellido(p_apellido);
            
        }
        public void buscarPorDni(string p_dni, DataGridView p_dgv)
        {
            p_dgv.DataSource = objUsuario.filtrarPorDni(p_dni);
        }

        public int buscarIdUltimo()
        {
            return objUsuario.obtenerIdUltimo();
        }
        public int buscarIDPeronsaUltimo()
        {
            return objUsuario.obtenerIdPersonaUltimo();
        }
 
    }
}
