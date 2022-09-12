using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Forms.Administrador;
using VIKINGO_PROJECT.Forms.Supervisor;
using VIKINGO_PROJECT.Forms.Vendedor;

namespace VIKINGO_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BSesion_Click(object sender, EventArgs e)
        {
            ///luego de validar
            if (TBUsuario.Text == "v")
            {
                Menu_vendedor menu_v = new Menu_vendedor();
                this.Hide();
                menu_v.ShowDialog();
                this.Show();

            }
            if (TBUsuario.Text == "a")
            {
                Menu_administrador menu_a = new Menu_administrador();
                this.Hide();
                menu_a.ShowDialog();
                this.Show();

            }
            if (TBUsuario.Text == "s")
            {
                Menu_supervisor menu_s = new Menu_supervisor();
                this.Hide(); //oculta el form actual
                menu_s.ShowDialog();
                this.Show();
                

            }
        }
        private bool verificar_campos_no_vacios()
        {
            if(TBUsuario.Text != "" && TBPassword.Text != "")
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
