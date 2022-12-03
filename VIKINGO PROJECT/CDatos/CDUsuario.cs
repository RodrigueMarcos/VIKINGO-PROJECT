using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.CDatos
{
    internal class CDUsuario
    {
        VIKINGO baseDatos = new VIKINGO();
        
        public bool insertarUsuario(Persona p_persona, Usuario p_usuario)
        {
            
            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {
                    baseDatos.Persona.Add(p_persona);
                    baseDatos.Usuario.Add(p_usuario);
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }


        }

        public bool insertarUsuario(Usuario p_usuario)
        {
            try
            {
                baseDatos.Usuario.Add(p_usuario);
                baseDatos.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }*/

        public List<UsuarioCompleto> listarUsuarios()
        {
            var consulta = (from u in baseDatos.Usuario
                            join p in baseDatos.Persona on u.id_persona equals p.ID_persona
                            join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                            join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                            join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                            join t in baseDatos.Tipo_usuario on u.tipo_usuario equals t.ID_tipoUsuario
                            join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                            select new UsuarioCompleto
                            {
                                DNI = p.DNI,
                                Apellido = p.apellido,
                                Nombre = p.nombre,
                                Contacto = p.telefono,
                                Email = p.email,
                                Domicilio = p.domicilio,
                                Genero = g.descripcion,
                                Tipo_Usuario = t.descripcion,
                                Localidad = l.nombre,
                                Ciudad = pro.Nombre,
                                ID_localidad = l.ID_localidad,
                                Fecha_DeNacimiento = u.fecha_nacimiento,
                                Fecha_DeIngreso = u.fecha_ingreso,
                                id_Estado = p.id_estado,
                                Estado = e.descripcion,
                                Usuario = u.usuario1,
                                Password = u.contraseña,
                                ID_usuario = u.ID_usuario,
                                id_persona = p.ID_persona
                            }).ToList();
            return consulta;
        }
        public List<UsuarioCompleto> filtrarPorApellido(string p_apellido)
        {
            var consulta = (from u in baseDatos.Usuario
                            join p in baseDatos.Persona on u.id_persona equals p.ID_persona
                            join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                            join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                            join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                            join t in baseDatos.Tipo_usuario on u.tipo_usuario equals t.ID_tipoUsuario
                            join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                            where p.apellido.StartsWith(p_apellido)
                            select new UsuarioCompleto
                            {
                                DNI = p.DNI,
                                Apellido = p.apellido,
                                Nombre = p.nombre,
                                Contacto = p.telefono,
                                Email = p.email,
                                Domicilio = p.domicilio,
                                Genero = g.descripcion,
                                Tipo_Usuario = t.descripcion,
                                Localidad = l.nombre,
                                Ciudad = pro.Nombre,
                                ID_localidad = l.ID_localidad,
                                Fecha_DeNacimiento = u.fecha_nacimiento,
                                Fecha_DeIngreso = u.fecha_ingreso,
                                id_Estado = p.id_estado,
                                Estado = e.descripcion,
                                Usuario = u.usuario1,
                                Password = u.contraseña,
                                ID_usuario = u.ID_usuario,
                                id_persona = p.ID_persona
                            }).ToList();
            return consulta;
        }
        public List<UsuarioCompleto> filtrarPorDni(string p_dni)
        {
            var consulta = (from u in baseDatos.Usuario
                            join p in baseDatos.Persona on u.id_persona equals p.ID_persona
                            join g in baseDatos.Genero on p.id_genero equals g.ID_genero
                            join l in baseDatos.Localidad on p.id_localidad equals l.ID_localidad
                            join pro in baseDatos.Provincia on l.id_provincia equals pro.ID_provincia
                            join t in baseDatos.Tipo_usuario on u.tipo_usuario equals t.ID_tipoUsuario
                            join e in baseDatos.Estado on p.id_estado equals e.ID_estado
                            where p.DNI.ToString().StartsWith(p_dni)
                            select new UsuarioCompleto
                            {
                                
                                DNI = p.DNI,
                                Apellido = p.apellido,
                                Nombre = p.nombre,
                                Contacto = p.telefono,
                                Email = p.email,
                                Domicilio = p.domicilio,
                                Genero = g.descripcion,
                                Tipo_Usuario = t.descripcion,
                                Localidad = l.nombre,
                                Ciudad = pro.Nombre,
                                ID_localidad = l.ID_localidad,
                                Fecha_DeNacimiento = u.fecha_nacimiento,
                                Fecha_DeIngreso = u.fecha_ingreso,
                                id_Estado = p.id_estado,
                                Estado = e.descripcion,
                                Usuario = u.usuario1,
                                Password = u.contraseña,
                                ID_usuario = u.ID_usuario,
                                id_persona = p.ID_persona
                            }).ToList();
            return consulta;
        }

        public bool actualizarUsuario(Persona p_persona, Usuario p_usuario)
        {
            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {

                    baseDatos.Entry(p_persona).State = EntityState.Modified;
                    baseDatos.Entry(p_usuario).State = EntityState.Modified;
                    baseDatos.SaveChanges();
                    transaccion.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaccion.Rollback();
                    return false;
                }
            }
        }
        public int obtenerIdUltimo()
        {
            try
            {
                return (from u in baseDatos.Usuario
                        orderby u.ID_usuario descending
                        select u.ID_usuario).ToList().First();
            }catch(Exception)
            {
                return 0;
            }
            
        }
        public int obtenerIdPersonaUltimo()
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
