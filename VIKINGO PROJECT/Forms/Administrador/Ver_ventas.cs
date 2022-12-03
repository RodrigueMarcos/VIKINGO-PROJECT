using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    public partial class Ver_ventas : Form
    {
        LFactura facturas = new LFactura();
        public Ver_ventas()
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            RBTodo.Checked=true;
            cargarFacturas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Producto_Click(object sender, EventArgs e)
        {

        }

        

        private void RBEspecificar_CheckedChanged(object sender, EventArgs e)
        {
            
            BBuscar.Enabled = true;
            TBCliente.Enabled = true;
            CBVendedores.Enabled = true;
            DTDesde.Enabled = true;
            DTHasta.Enabled = true;
 //           cargarMenuVendedor();

        }

        private void RBTodo_CheckedChanged(object sender, EventArgs e)
        {
            
            BBuscar.Enabled = false;
            TBCliente.Enabled = false;
            CBVendedores.Enabled = false;
            DTDesde.Enabled = false;
            DTHasta.Enabled = false;
            cargarFacturas();
        }

        private void BBuscar3_Click(object sender, EventArgs e)
        {
            if (DTDesde.Value <= DTHasta.Value)
            {
                LAdvertencia.Text = "";
                //Procedimiento de buscar
            }
            else
            {
                LAdvertencia.Text = "EL INICIO DE LA FECHA DE BUSQUEDA DEBE SER MENOR O IGUAL A LA DE FINAL";
            }
        }
        private void cargarFacturas()
        {
            facturas.listarFacturas(DGV_Facturas);
        }

        private void DGV_Facturas_Click(object sender, EventArgs e)
        {
            int id_factura = Convert.ToInt32(DGV_Facturas.CurrentRow.Cells["ID_Factura"].Value);
            facturas.listarDetalles(id_factura, DGV_Detalles);
        }
        private void cargarMenuVendedor()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var consulta = (from u in db.Usuario
                                join p in db.Persona on u.id_persona equals p.ID_persona
                                where u.tipo_usuario == "V"
                                select new MenuVendedor
                                {
                                    nombreCompleto = p.apellido + " " + p.nombre,
                                    dni = p.ID_persona
                                }).ToList();
                CBVendedores.DataSource = consulta;
                CBVendedores.DisplayMember = "nombreCompleto";
                CBVendedores.ValueMember = "dni";
            }
        }

        private void TBProducto_KeyUp(object sender, KeyEventArgs e)
        {
            facturas.listarFacturasPorCliente(TBCliente.Text, DGV_Facturas);
        }

        class MenuVendedor
        {
            public string nombreCompleto { get; set; }
            public int dni { get; set; }
        }

        

        

        private void CBVendedores_DropDown(object sender, EventArgs e)
        {
            cargarMenuVendedor();
        }

        private void CBVendedores_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(CBVendedores.SelectedValue);
            facturas.listarFacturasPorVendedor(dni, DGV_Facturas);
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(DTDesde.Value <= DTHasta.Value)
            {
                facturas.listarFacturaPorFecha(DTDesde.Value, DTHasta.Value, DGV_Facturas);
            }
            else
            {
                LAdvertencia.Text = "EL VALOR DE LA FECHA DESDE NO PUEDE SER MAYOR QUE EL DE LA FECHA HASTA";
            }

        }

        private void TBCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR CARACTERES DE A-Z";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV_Facturas.SelectedRows.Count > 0)
            {
                int id_factura = Convert.ToInt32(DGV_Facturas.CurrentRow.Cells["ID_factura"].Value);
                DateTime fechaRegistrada = Convert.ToDateTime(DGV_Facturas.CurrentRow.Cells["Fecha"].Value);
                string tipoFactura = Convert.ToString(DGV_Facturas.CurrentRow.Cells["Tipo_Factura"].Value);
                string nombreCliente = Convert.ToString(DGV_Facturas.CurrentRow.Cells["Cliente"].Value);
                string dniCliente = Convert.ToString(DGV_Facturas.CurrentRow.Cells["Dni"].Value);
                string total = Convert.ToString(DGV_Facturas.CurrentRow.Cells["Total"].Value);



                SaveFileDialog save = new SaveFileDialog();
                string nombre_archivo = "NroFac-" + Convert.ToString(id_factura) + "-" + fechaRegistrada.ToString("ddMMyyyy") + "-VIKINGO" + ".pdf";
                save.FileName = nombre_archivo;

                string html = Properties.Resources.Plantilla.ToString(); //tiene el codigo de html
                string producto_fila = string.Empty;

                //reemplaza mas parte de textos x el parametro que se le pasa
                html = html.Replace("@NUMFACTURA", Convert.ToString(id_factura));
                html = html.Replace("@TIPOFACTURA", tipoFactura);
                html = html.Replace("@CLIENTE", nombreCliente);
                html = html.Replace("@DOCUMENTO", dniCliente);
                html = html.Replace("@FECHA", fechaRegistrada.ToString("dd/MM/yyyy"));
                html = html.Replace("@TOTAL", Convert.ToString(total));
                //creamos las tabla de detalles (escrito en código html)
                //el indice de la primera columna empieza en 1        
                foreach (DataGridViewRow row in DGV_Detalles.Rows)
                {
                    producto_fila += "<tr>";
                    producto_fila += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                    producto_fila += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                    producto_fila += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                    producto_fila += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                    producto_fila += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                    producto_fila += "<td>" + row.Cells[5].Value.ToString() + "</td>";
                    producto_fila += "</tr>";
                }
                html = html.Replace("@FILAS", producto_fila);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25); //caracteristica del documento
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); //nos permite escribir
                        pdfDoc.Open(); //abre el documento

                        //agregar imagen en el pdf
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_vikingo, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(80, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img); //va a agregar la imagen con el formato que le dimos al pdf

                        using (StringReader sr = new StringReader(html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr); //inserta el contenido del html en el pdf
                        }
                        //Obtener dirección
                        string direccion = save.FileName;
                        pdfDoc.Close(); // cierra el documento
                        stream.Close(); // cierra el estilo de memoria
                        //abrir archivo
                        Process proceso = new Process();
                        proceso.StartInfo.FileName = direccion;//@"D:\Documents\Proyectos\VIKINGO PROJECT\Facturaciones pdf\"+nombre_archivo;
                        proceso.Start();
                    }

                }

            }
            else
            {
                MessageBox.Show("Debes selecionar una factura de la lista primero.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
