using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VIKINGO_PROJECT.Forms.SuperAdministrador
{
    public partial class Backup_form : Form
    {
        SqlConnection conexion = new SqlConnection("data source=.\\SQLEXPRESS;initial catalog=VIKINGO;integrated security=True");
        public Backup_form()
        {
            InitializeComponent();
        }

        private void Bbackup_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("¿Desea realizar una copia de seguridad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == ask)
            {
                try
                {
                    if (Directory.Exists("D:\\Documents\\backup\\"))//  D:\\Documents\\backup\\
                    {
                        string nombre_archivo = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-VIKINGO.bak");
                        string consulta = "BACKUP DATABASE [VIKINGO] TO  DISK = N'D:\\Documents\\backup\\" + nombre_archivo + "' WITH NOFORMAT, NOINIT,  NAME = N'VIKINGO-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                        SqlCommand cmd = new SqlCommand(consulta, conexion);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("LA COPIA DE SEGURIDAD FUE HECHO CON EXITO", "Copia de seguridad realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error en la copia de seguridad. Verifique estar conectado a la red.", "Copia de seguridad no realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error durante la copia de seguridad.", "Copia de seguridad no realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
         
        }
    }
}
