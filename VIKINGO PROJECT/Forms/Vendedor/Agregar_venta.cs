using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml.simpleparser.handler;
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
using static System.Net.WebRequestMethods;

namespace VIKINGO_PROJECT.Forms.Vendedor
{
    public partial class Agregar_venta : Form
    {
        //Si intancia aca no me actualiza la lista luego de a ver registrado un venta sin a ver salido del form
        //Ver_productos productos = new Ver_productos();
        
        Listar_clientes clientes = new Listar_clientes();
        private int codigo;
        private string nombreProducto;
        private decimal precio;
        private int stockActual;
        private string descripcionPro;
        private decimal totalGeneral;
        private int dniCliente = -1;
        private string apellidoCliente;
        private string nombreCliente;
        private int id_vendedor;
        private int id_personaCliente;
        private string nombreV;
        private string apellidoV;
        public Agregar_venta(string p_nombre, string p_apellido, int p_id)
        {
            InitializeComponent();
            LAdvertencia.Text = "";
            cargarMenuTipoFactura();
            cargarMenuTipoPago();
            id_vendedor = p_id;
            nombreV = p_nombre;
            apellidoV = p_apellido;

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress(sender, e);
        }

        private void solo_numerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS";

            }
        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress((object)sender, e);
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numerico_KeyPress((object)sender, e);
        }

        private void solo_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
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

        private void TBApeNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_letras_KeyPress(e.KeyChar, e);
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (TBCodigo.Text != "")
            {
                if (verificarProductoDuplicado() == false)
                {
                    if (verificarCantidad())
                    {
                        int cantidad = Convert.ToInt32(TBCantidad.Text);
                        decimal subTotal = precio * cantidad;
                        DGV_Detalle.Rows.Add(codigo, nombreProducto, descripcionPro, cantidad, precio, subTotal, "Eliminar");
                        //totalGeneral = totalGeneral + subTotal;
                        //LTotal.Text = Convert.ToString(totalGeneral);
                        calcularTotal();
                    }
                }

            }
            else
            {
                MessageBox.Show("Debes ingresar el código, nombre y cantidad del producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BBuscarPro_Click(object sender, EventArgs e)
        {
            //buscar el producto
            Ver_productos productos = new Ver_productos("seleccionar");
            if (productos.ShowDialog() == DialogResult.OK)
            {
                codigo = productos.codigo;
                if (verificarProductoDuplicado() == false)
                {
                    nombreProducto = productos.nombre;
                    precio = productos.precio;
                    stockActual = productos.cantidad;
                    descripcionPro = productos.descripcion;

                    TBCodigo.Text = Convert.ToString(codigo);
                    TBNombre.Text = nombreProducto;
                    TBPrecio.Text = Convert.ToString(precio);
                    TBStockAct.Text = Convert.ToString(stockActual);
                }


            }


        }
        private bool verificarCantidad()
        {
            if (TBCantidad.Text != "")
            {
                int cantidadPedida = Convert.ToInt32(TBCantidad.Text);
                if (cantidadPedida <= stockActual && cantidadPedida != 0)
                {
                    return true;
                }
                else
                {
                    LAdvertencia.Text = "LA CANTIDAD PEDIDA ES SUPERIOR AL STOCK ACTUAL O IGUAL A 0";
                    return false;
                }
            }
            else
            {
                LAdvertencia.Text = "DEBES INGRESAR UNA CANTIDAD";
                return false;
            }
        }
        private bool verificarProductoDuplicado()
        {
            if (DGV_Detalle.RowCount == 0)
            {
                return false;

            }
            else
            {
                DGV_Detalle.ClearSelection();
                int valor;
                for (int i = 0; i < DGV_Detalle.Rows.Count; i++)
                {
                    valor = Convert.ToInt32(DGV_Detalle.Rows[i].Cells[0].Value);
                    if (valor == codigo)
                    {
                        MessageBox.Show("El producto con código " + codigo.ToString() + " fue cargo en el detalle anteriormente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DGV_Detalle.Rows[i].Selected = true;
                        return true;
                    }
                }
                return false;
            }
        }

        private void DGV_Detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Detalle.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult ask = MessageBox.Show("¿Deseas eliminar la fila?", "Confirmacón", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    //totalGeneral = totalGeneral - Convert.ToDecimal(DGV_Detalle.CurrentRow.Cells["Sub_total"].Value);
                    //LTotal.Text = Convert.ToString(totalGeneral);
                    DGV_Detalle.Rows.RemoveAt(DGV_Detalle.CurrentRow.Index);
                    calcularTotal();
                }
            }

        }

        private void BAgregarCli_Click(object sender, EventArgs e)
        {
            //buscar el cliente

            if (clientes.ShowDialog() == DialogResult.OK)
            {
                dniCliente = clientes.dni;
                apellidoCliente = clientes.apellido;
                nombreCliente = clientes.nombre;
                id_personaCliente = clientes.id_personaCliente;

                TBDni.Text = Convert.ToString(dniCliente);
                TBApeNom.Text = apellidoCliente + " " + nombreCliente;

            }

        }
        private void cargarMenuTipoFactura()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listarTipoFac = (from tf in db.TipoFactura orderby tf.descripcion ascending select tf).ToList();
                CBTipoFac.DataSource = listarTipoFac;
                CBTipoFac.DisplayMember = "descripcion";
                CBTipoFac.ValueMember = "ID_TipoFactura";
            }
        }

        private void cargarMenuTipoPago()
        {
            using (VIKINGO db = new VIKINGO())
            {
                var listarTipoPago = (from fp in db.FormaPago orderby fp.descripcion ascending select fp).ToList();
                CBTipoPago.DataSource = listarTipoPago;
                CBTipoPago.DisplayMember = "descripcion";
                CBTipoPago.ValueMember = "ID_formaPago";
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (dniCliente > 0)
            {
                if (DGV_Detalle.Rows.Count > 0)
                {
                    DialogResult ask = MessageBox.Show("¿Desea registrar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        LFactura factura = new LFactura();
                        
                        int idFactura = factura.buscarUltimoID() + 1;
                        int idTipoFactura = Convert.ToInt32(CBTipoFac.SelectedValue);
                        int idFormaPago = Convert.ToInt32(CBTipoPago.SelectedValue);
                      
                        if (factura.facturarVenta(idFactura, id_personaCliente, id_vendedor, idTipoFactura, idFormaPago,
                            totalGeneral, DGV_Detalle))
                        {
                            DialogResult askk = MessageBox.Show("Compra registrada. ¿Desea imprimir la factura?", "¡Gracias por su compra!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(askk == DialogResult.Yes)
                            {
                                SaveFileDialog save = new SaveFileDialog();
                                string nombre_archivo = "NroFac-" + Convert.ToString(idFactura)+"-"+DateTime.Now.ToString("ddMMyyyy") + "-VIKINGO"+".pdf";
                                save.FileName = nombre_archivo;
                                
                                string html = Properties.Resources.Plantilla.ToString(); //tiene el codigo de html
                                string producto_fila = string.Empty;

                                //reemplaza mas parte de textos x el parametro que se le pasa
                                html = html.Replace("@NUMFACTURA", Convert.ToString(idFactura));
                                html = html.Replace("@TIPOFACTURA", CBTipoFac.Text);
                                html = html.Replace("@CLIENTE", TBApeNom.Text);
                                html = html.Replace("@DOCUMENTO", TBDni.Text);
                                html = html.Replace("@VENDEDOR", apellidoV+", "+nombreV);
                                html = html.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                                html = html.Replace("@TOTAL", Convert.ToString(totalGeneral));
                                //creamos las tabla de detalles (escrito en código html)
                                //el indice de la primera columna empieza en 0        
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

                                if(save.ShowDialog() == DialogResult.OK)
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

//                            MessageBox.Show(, "Compra registrada", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Se presento un error interno a la hora de registrar la compra. " +
                                "Vuelva a intentar o contáctese con el administrador", "Error durante el registro de factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("DEBES REALIZAR AL MENOS UNA VENTA", "NO SE CARGO NINGUNA VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("EL CAMPO DNI, APELLIDO Y NOMBRE NO FUE CARGADO", "SELECCIONE UN CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            codigo = 0;
            nombreProducto = "";
            precio = 0;
            stockActual = 0;
            descripcionPro = "";
            totalGeneral = 0;
            dniCliente = -1;
            apellidoCliente = "";
            nombreCliente = "";
            TBDni.Clear();
            TBApeNom.Clear();
            TBCodigo.Clear();
            TBPrecio.Clear();
            TBNombre.Clear();
            TBStockAct.Clear();
            TBCantidad.Clear();
            DGV_Detalle.Rows.Clear();
            LTotal.Text = Convert.ToString(totalGeneral);
        }

        private void DGV_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LAdvertencia.Text = "";

            }
            else
            {
                e.Handled = true;
                LAdvertencia.Text = "*DEBES INGRESAR SOLO DATOS NUMERICOS";

            }
        }

        private void DGV_Detalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (DGV_Detalle.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(DGV_Detalle_KeyPress);
                }
            }
        }

        private void DGV_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int valor = Convert.ToInt32(DGV_Detalle.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int fila = DGV_Detalle.CurrentCell.RowIndex;
                int columna = DGV_Detalle.CurrentCell.ColumnIndex;
                int codigoPro = Convert.ToInt32(DGV_Detalle.Rows[e.RowIndex].Cells[0].Value);
                LProducto lProducto = new LProducto();
                int stockProducto = lProducto.obtenerStockProducto(codigoPro);
                if (!(valor > 0))
                {
                    MessageBox.Show("La columna cantidad no permite el ingreso de cantidades iguales a 0 o" +
                        " a nulo, por defecto el valor asignado es 1", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DGV_Detalle.Rows[fila].Cells[columna].Value = 1;
                    DGV_Detalle.Rows[fila].Cells[5].Value = 1 * Convert.ToInt32(DGV_Detalle.Rows[fila].Cells[4].Value);
                    calcularTotal();
                }
                if (valor > stockProducto)
                {
                    MessageBox.Show("La columna cantidad no permite el ingreso de cantidades mayores al stock actual.(Stock actual es " + stockProducto + "). Por defecto sera 0.", "Cantidad no admitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DGV_Detalle.Rows[fila].Cells[columna].Value = 0;
                    DGV_Detalle.Rows[fila].Cells[5].Value = 0 * Convert.ToInt32(DGV_Detalle.Rows[fila].Cells[4].Value);
                    calcularTotal();
                }
                if(valor <= stockProducto)
                {
                    DGV_Detalle.Rows[fila].Cells[5].Value = valor * Convert.ToInt32(DGV_Detalle.Rows[fila].Cells[4].Value);
                    calcularTotal(); 
                }
            }
        }
        private void calcularTotal()
        {
            totalGeneral = 0;
            for(int i = 0; i < DGV_Detalle.Rows.Count; i++)
            {
                totalGeneral+= Convert.ToDecimal(DGV_Detalle.Rows[i].Cells[5].Value);
            }
            LTotal.Text = totalGeneral.ToString();
        }
    }
}