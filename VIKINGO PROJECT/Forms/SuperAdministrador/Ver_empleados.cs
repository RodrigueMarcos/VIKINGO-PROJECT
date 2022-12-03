using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Ver_empleados : Form
    {
        LUsuario usuario = new LUsuario();
        public Ver_empleados()
        {
            InitializeComponent();
            listarEmpleados();
        }

        private void listarEmpleados()
        {
            usuario.cargarDataGridView(DGV_Lista);
        }
    }
}
