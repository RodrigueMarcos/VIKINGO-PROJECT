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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Diagnostics;


namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Ver_facturaciones : Form
    {
        private int idVendedor;
        LFactura facturas = new LFactura();
        public Ver_facturaciones(int p_id)
        {
            InitializeComponent();
            idVendedor = p_id;
            cargarFacturacionesCompleta();
        }
        private void cargarFacturacionesCompleta()
        {
            facturas.listarFacturasDelVendedor(idVendedor, DGV_Facturas);
        }
        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Facturas_Click(object sender, EventArgs e)
        {
            int id_factura = Convert.ToInt32(DGV_Facturas.CurrentRow.Cells["ID_Factura"].Value);
            facturas.listarDetalles(id_factura, DGV_Detalle);
        }

        private void RBHoy_CheckedChanged(object sender, EventArgs e)
        {
            facturas.listarFacturasHoy(idVendedor, DGV_Facturas);
        }

        private void RBTodos_CheckedChanged(object sender, EventArgs e)
        {
            cargarFacturacionesCompleta();
        }

        private void BPDF_Click(object sender, EventArgs e)
        {
            if(DGV_Facturas.SelectedRows.Count > 0)
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
                foreach (DataGridViewRow row in DGV_Detalle.Rows)
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
                        //ABRIR EL ARCHIVO
                        string direccion = save.FileName;
                        pdfDoc.Close(); // cierra el documento
                        stream.Close(); // cierra el estilo de memoria

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
