using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIKINGO_PROJECT.CDatos
{
    internal class CDCiudad
    {
        VIKINGO baseDatos = new VIKINGO();

        public bool insertar(Provincia p_provincia)
        {
            try
            {
               baseDatos.Provincia.Add(p_provincia);
               baseDatos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        /*public int returnIDlocalidad(string p_provincia,string p_localidad)
        {
            try
            {
                int consulta = (from l in baseDatos.Localidad
                               join p in baseDatos.Provincia on l.id_provincia equals p.ID_provincia
                               where l.nombre == p_localidad 
                               select l.ID_localidad).FirstOrDefault();
                MessageBox.Show(Convert.ToString(consulta));
                return 1;
            }catch (Exception e)
            {
                return -1;
            }
        }*/
    }
}
