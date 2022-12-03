using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.CDatos
{
    internal class CDCliente
    {
        VIKINGO baseDatos = new VIKINGO();
        ClienteCompleto cliente = new ClienteCompleto();

        public bool agregarCliente(Cliente p_cliente, Persona p_persona)
        {
            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {
                    baseDatos.Persona.Add(p_persona);
                    baseDatos.Cliente.Add(p_cliente);
                    baseDatos.SaveChanges();
                    transaccion.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    return false;
                }
            }
        }
        /*public bool agregarPersona(Persona p_persona)
        {
            try
            {              
                baseDatos.Persona.Add(p_persona);
                baseDatos.SaveChanges();
                return true;
            }catch (Exception e){
                MessageBox.Show(e.Message);
                return false;
            }

            
        }
        public bool insertarCliente(Cliente p_cliente)
        { 
            try
            {               
                baseDatos.Cliente.Add(p_cliente);
                baseDatos.SaveChanges();
                return true;
            }catch (Exception e) {
                MessageBox.Show(e.InnerException.Message);
                return false; }
        }*/

        public List<ClienteCompleto> getClienteAll()
        {
            var listaClientes = (from p in baseDatos.Persona 
                                 join c in baseDatos.Cliente on p.ID_persona equals c.id_persona
                                 join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                                 join t in baseDatos.Tipo_cliente on c.id_tipoCliente equals t.ID_tipoCliente
                                 join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                                 join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                                 join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                                 orderby c.ID_cliente descending
                                 select new ClienteCompleto
                                 {
                                     ID_cliente = c.ID_cliente,
                                     DNI = p.DNI,
                                     Apellido = p.apellido,
                                     Nombre = p.nombre,
                                     Contacto = p.telefono,
                                     Email = p.email,
                                     Domicilio = p.domicilio,
                                     Genero = g.descripcion,
                                     Tipo = t.descripcion,
                                     Ciudad = pro.Nombre,
                                     Localidad = l.nombre,
                                     ID_localidad = l.ID_localidad,
                                     Fecha_DeIngreso = c.fecha_registro,
                                     id_estado = p.id_estado,
                                     Estado = e.descripcion,
                                     ID_persona = p.ID_persona
                                 }).ToList();
            return listaClientes;
        }

        public List<ClienteCompleto> getClienteHabilitado()
        {
            var listaClientes = (from p in baseDatos.Persona
                                 join c in baseDatos.Cliente on p.ID_persona equals c.id_persona
                                 join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                                 join t in baseDatos.Tipo_cliente on c.id_tipoCliente equals t.ID_tipoCliente
                                 join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                                 join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                                 join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                                 orderby c.ID_cliente descending
                                 where p.id_estado == "H"
                                 select new ClienteCompleto
                                 {
                                     ID_cliente = c.ID_cliente,
                                     DNI = p.DNI,
                                     Apellido = p.apellido,
                                     Nombre = p.nombre,
                                     Contacto = p.telefono,
                                     Email = p.email,
                                     Domicilio = p.domicilio,
                                     Genero = g.descripcion,
                                     Tipo = t.descripcion,
                                     Ciudad = pro.Nombre,
                                     Localidad = l.nombre,
                                     ID_localidad = l.ID_localidad,
                                     Fecha_DeIngreso = c.fecha_registro,
                                     id_estado = p.id_estado,
                                     Estado = e.descripcion,
                                     ID_persona = p.ID_persona
                                 }).ToList();
            return listaClientes;
        }

        public bool actualizarCliente(Persona p_persona, Cliente p_cliente)
        {
            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {
                    baseDatos.Entry(p_persona).State = EntityState.Modified;
                    baseDatos.Entry(p_cliente).State = EntityState.Modified;
                    baseDatos.SaveChanges();
                    transaccion.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    return false;
                }
            }
                        
        }

        public List<ClienteCompleto> filtrarClienteDni(string p_dni)
        {
           
            try
            {
                var listaClientes = (from p in baseDatos.Persona
                                     join c in baseDatos.Cliente on p.ID_persona equals c.id_persona
                                     join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                                     join t in baseDatos.Tipo_cliente on c.id_tipoCliente equals t.ID_tipoCliente
                                     join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                                     join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                                     join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                                     where p.DNI.ToString().StartsWith(p_dni)
                                     orderby c.ID_cliente descending
                                     select new ClienteCompleto
                                     {
                                         ID_cliente = c.ID_cliente,
                                         DNI = p.DNI,
                                         Apellido = p.apellido,
                                         Nombre = p.nombre,
                                         Contacto = p.telefono,
                                         Email = p.email,
                                         Domicilio = p.domicilio,
                                         Genero = g.descripcion,
                                         Tipo = t.descripcion,
                                         Ciudad = pro.Nombre,
                                         Localidad = l.nombre,
                                         ID_localidad = l.ID_localidad,
                                         Fecha_DeIngreso = c.fecha_registro,
                                         id_estado = p.id_estado,
                                         Estado = e.descripcion,
                                         ID_persona = p.ID_persona
                                     }).ToList();
                return listaClientes;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public List<ClienteCompleto> filtrarClienteNombre(string p_nombre)
        {
            try
            {
                var listaClientes = (from p in baseDatos.Persona
                                     join c in baseDatos.Cliente on p.ID_persona equals c.id_persona
                                     join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                                     join t in baseDatos.Tipo_cliente on c.id_tipoCliente equals t.ID_tipoCliente
                                     join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                                     join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                                     join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                                     where p.nombre.StartsWith(p_nombre)
                                     orderby c.ID_cliente descending
                                     select new ClienteCompleto
                                     {
                                         ID_cliente = c.ID_cliente,
                                         DNI = p.DNI,
                                         Apellido = p.apellido,
                                         Nombre = p.nombre,
                                         Contacto = p.telefono,
                                         Email = p.email,
                                         Domicilio = p.domicilio,
                                         Genero = g.descripcion,
                                         Tipo = t.descripcion,
                                         Ciudad = pro.Nombre,
                                         Localidad = l.nombre,
                                         ID_localidad = l.ID_localidad,
                                         Fecha_DeIngreso = c.fecha_registro,
                                         id_estado = p.id_estado,
                                         Estado = e.descripcion,
                                         ID_persona = p.ID_persona
                                     }).ToList();
                return listaClientes;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public List<ClienteCompleto> filtrarClienteApellido(string p_apellido)
        {
            try
            {
                var listaClientes = (from p in baseDatos.Persona
                                     join c in baseDatos.Cliente on p.ID_persona equals c.id_persona
                                     join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                                     join t in baseDatos.Tipo_cliente on c.id_tipoCliente equals t.ID_tipoCliente
                                     join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                                     join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                                     join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                                     where p.apellido.StartsWith(p_apellido)
                                     orderby c.ID_cliente descending
                                     select new ClienteCompleto
                                     {
                                         ID_cliente = c.ID_cliente,
                                         DNI = p.DNI,
                                         Apellido = p.apellido,
                                         Nombre = p.nombre,
                                         Contacto = p.telefono,
                                         Email = p.email,
                                         Domicilio = p.domicilio,
                                         Genero = g.descripcion,
                                         Tipo = t.descripcion,
                                         Ciudad = pro.Nombre,
                                         Localidad = l.nombre,
                                         ID_localidad = l.ID_localidad,
                                         Fecha_DeIngreso = c.fecha_registro,
                                         id_estado= p.id_estado,
                                         Estado = e.descripcion,
                                         ID_persona = p.ID_persona
                                     }).ToList();
                return listaClientes;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public int obtenerUltimaIdPersona()
        {
            try
            {
                return (from p in baseDatos.Persona
                        orderby p.ID_persona descending
                        select p.ID_persona).ToList().First();
            }
            catch (Exception)
            {
                return 0;
            }
        }






    }
}
