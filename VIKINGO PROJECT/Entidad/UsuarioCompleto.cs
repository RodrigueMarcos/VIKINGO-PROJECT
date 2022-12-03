using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGO_PROJECT.Entidad
{
    internal class UsuarioCompleto
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public long Contacto { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Genero { get; set; }
        public string Localidad { get; set; }
        public int ID_localidad { get; set; }
        public string Ciudad { get; set; }
        public string id_Estado { get; set; }
        public string Estado { get; set; }
        public int id_persona { get; set; }

        
        
        public DateTime Fecha_DeNacimiento { get; set; }
        public DateTime Fecha_DeIngreso { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int ID_usuario { get; set; }
    }
}
