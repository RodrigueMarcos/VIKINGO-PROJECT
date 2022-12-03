using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGO_PROJECT.CDatos;

namespace VIKINGO_PROJECT.logica
{
    internal class LCiudad
    {
        

        public bool agregar_provincia(string p_ciudad)
        {
            Provincia objCiudad = new Provincia();
            
            objCiudad.Nombre = p_ciudad;
            
            //objCiudad.ID_ciudad = 0;

            CDCiudad objCiudades = new CDCiudad();

            if (objCiudades.insertar(objCiudad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    
    }
}
