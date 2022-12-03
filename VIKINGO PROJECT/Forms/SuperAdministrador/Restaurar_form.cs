using iTextSharp.tool.xml.html;
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

namespace VIKINGO_PROJECT.Forms.SuperAdministrador
{
    public partial class Restaurar_form : Form
    {
        SqlConnection conexion = new SqlConnection("data source=.\\SQLEXPRESS;initial catalog=VIKINGO;integrated security=True");

        public Restaurar_form()
        {
            InitializeComponent();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string direccion = openFileDialog.FileName;
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("ALTER DATABASE VIKINGO SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE VIKINGO FROM disk='" + direccion + "'", conexion);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se realizo correctamente la restauración de respaldo de datos", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error interno durante la operación de restaurar", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }


        }
    }
}
