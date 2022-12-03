using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGO_PROJECT.CDatos;

namespace VIKINGO_PROJECT.Entidad
{
    internal class ClienteCompleto
    {
        
            public int ID_persona { get; set; }
            public int DNI { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public long Contacto { get; set; }
            public string Email { get; set; }
            public string Domicilio { get; set; }
            public string Genero { get; set; }
            public string Tipo { get; set; }

            public int ID_cliente { get; set; }
            public string Localidad { get; set; }
            public string Ciudad { get; set; }
            public int ID_localidad { get; set; }
            public DateTime Fecha_DeIngreso { get; set; }
            public string id_estado { get; set; }
            public string Estado { get; set; }



    }
}
