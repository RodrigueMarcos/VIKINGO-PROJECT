using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;

namespace VIKINGO_PROJECT.logica
{
    internal class LCliente
    {
        CDCliente objCliente = new CDCliente();
        /*public bool agregar_persona(int p_dni, string p_apellido, string p_nombre,
            long p_telefono, string p_email, int p_localidad,string p_direccion, int p_genero, int p_tipo)
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
            persona.id_estado = "H";

            //2do cargamos el objeto personas en la BD
            CDCliente objCliente = new CDCliente();
            if (objCliente.agregarPersona(persona))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool agregarCliente(int p_dni, int p_tipoCliente)
        {
            //3ro creamos un objeto cliente
            Cliente cliente = new Cliente();
            cliente.dni = p_dni;
            cliente.id_tipoCliente = p_tipoCliente;
            cliente.fecha_registro = DateTime.Now;
            //4to agregamos cliente en BD
            CDCliente objcliente = new CDCliente();
            if (objcliente.insertarCliente(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }*/

        public bool agregarCliente(int p_dni, string p_apellido, string p_nombre,
            long p_telefono, string p_email, int p_localidad, string p_direccion,
            int p_genero, int p_tipoCliente)
        {
            Persona persona = new Persona();
            int idPersona = buscarUltimoIdPersona() + 1;
            persona.ID_persona = idPersona;
            persona.DNI = p_dni;
            persona.nombre = p_nombre;
            persona.apellido = p_apellido;
            persona.telefono = p_telefono;
            persona.email = p_email;
            persona.domicilio = p_direccion;
            persona.id_localidad = p_localidad;
            persona.id_genero = p_genero;
            persona.id_estado = "H";

            Cliente cliente = new Cliente();
            cliente.id_persona = idPersona;
            cliente.id_tipoCliente = p_tipoCliente;
            cliente.fecha_registro = DateTime.Now;

            
            if (objCliente.agregarCliente(cliente, persona))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public void cargarClientes(DataGridView dataGrid)
        {
            CDCliente objCliente = new CDCliente();
            dataGrid.DataSource = objCliente.getClienteAll();
            dataGrid.Columns["ID_persona"].Visible = false;
            dataGrid.Columns["ID_cliente"].Visible = false;
            dataGrid.Columns["ID_localidad"].Visible=false;
            dataGrid.Columns["id_estado"].Visible = false;

        }

        public void cargarClientesHabilitados(DataGridView p_dgv)
        {
            p_dgv.DataSource = objCliente.getClienteHabilitado();
            p_dgv.Columns["ID_persona"].Visible = false;
            p_dgv.Columns["ID_cliente"].Visible = false;
            p_dgv.Columns["ID_localidad"].Visible = false;
            p_dgv.Columns["id_estado"].Visible = false;
            p_dgv.Columns["Estado"].Visible = false;

        }

        public bool actualizar_persona(int p_idPersona, int p_dni, string p_apellido, string p_nombre,
            long p_telefono, string p_email, int p_localidad, string p_direccion, int p_genero,
            int p_tipoCliente, DateTime p_fechaIngreso, int p_idCliente,string p_estado)
        {
            //1er Crear el objeto persona
            Persona persona = new Persona();
            persona.ID_persona = p_idPersona;
            persona.DNI = p_dni;
            persona.nombre = p_nombre;
            persona.apellido = p_apellido;
            persona.telefono = p_telefono;
            persona.email = p_email;
            persona.domicilio = p_direccion;
            persona.id_localidad = p_localidad;
            persona.id_genero = p_genero;
            persona.id_estado = p_estado;

            //2do creo el objeto cliente
            Cliente cliente = new Cliente();
            cliente.ID_cliente = p_idCliente;
            cliente.id_persona = p_idPersona;
            cliente.id_tipoCliente = p_tipoCliente;
            cliente.fecha_registro = p_fechaIngreso;
            
            CDCliente objCliente = new CDCliente();
            if (objCliente.actualizarCliente(persona, cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void buscar_cliente_dni(string p_dni, DataGridView p_dgv)
        {
            
            p_dgv.DataSource = objCliente.filtrarClienteDni(p_dni);
            //p_dgv.Columns["Identificador"].Visible = false;
            //p_dgv.Columns["ID_localidad"].Visible = false;
            //p_dgv.Columns["Activo"].Visible = false;
        }

        public void buscar_cliente_nombre(string p_nombre, DataGridView p_dgv)
        {
            
            p_dgv.DataSource = objCliente.filtrarClienteNombre(p_nombre);
            //p_dgv.Columns["Identificador"].Visible = false;
            //p_dgv.Columns["ID_localidad"].Visible = false;
            //p_dgv.Columns["Activo"].Visible = false;
        }
        public void buscar_cliente_apellido(string p_apellido, DataGridView p_dgv)
        {
            
            p_dgv.DataSource = objCliente.filtrarClienteApellido(p_apellido);
            //p_dgv.Columns["Identificador"].Visible = false;
            //p_dgv.Columns["ID_localidad"].Visible = false;
            //p_dgv.Columns["Activo"].Visible = false;
        }
        public int buscarUltimoIdPersona()
        {
            return objCliente.obtenerUltimaIdPersona();
        }

    }
}
