using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.Diagnostics;
using System.IO;
using VIKINGO_PROJECT.logica;
using iTextSharp.text.pdf.qrcode;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace VIKINGO_PROJECT.Forms.Administrador
{
    
    public partial class Estadistica : Form
    {
        LFactura factura = new LFactura();
        SqlConnection coneccion = new SqlConnection("Server=DESKTOP-HL6NFTL\\SQLEXPRESS;DataBase=VIKINGO;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        string producto_fila;



        public Estadistica()
        {
            InitializeComponent();
            RBMasVendidos.Checked = true;
            graficarProductosMasVendidos();
            graficarCategoriaMasVendidas();
            mostrarTotales();
            exportarImagen();
            

        }
        private void graficarCategoriaMasVendidas()
        {
            
            ArrayList categoria = new ArrayList();
            ArrayList cantProd = new ArrayList();
            cmd = new SqlCommand("CategoriaMasVendida", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            coneccion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Add(dr.GetString(0));
                cantProd.Add(dr.GetInt32(1));

            }
            chartProdCategoria.Series[0].Points.DataBindXY(categoria, cantProd);
            dr.Close();
            coneccion.Close();
        }
        private void graficarProductosMasVendidos()
        {
            producto_fila = string.Empty;
            ArrayList producto = new ArrayList();
            ArrayList cant = new ArrayList();

            cmd = new SqlCommand("productosPrefe", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            coneccion.Open();
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                producto.Add(dr.GetString(1) + " " + dr.GetString(2));
                cant.Add(dr.GetInt32(4));
                producto_fila += "<tr>";
                producto_fila += "<td>" + Convert.ToString(dr.GetInt32(0)) + "</td>";
                producto_fila += "<td>" + dr.GetString(1) + "</td>";
                producto_fila += "<td>" + dr.GetString(2) + "</td>";
                producto_fila += "<td>" + dr.GetString(3) + "</td>";
                producto_fila += "<td>" + Convert.ToString(dr.GetInt32(4)) + "</td>";
                producto_fila += "</tr>";
            }
            
            chartProdPreferido.Series[0].Points.DataBindXY(producto, cant);
            dr.Close();
            coneccion.Close();
        }

        private void RBFecha_CheckedChanged(object sender, EventArgs e)
        {
            DTDesde.Enabled = true;
            DTHasta.Enabled = true;
            LBuscar.Enabled = true;
            LTituloGrafCat.Text = "Las 5 categoria mas vendidas";
            LTituloGrafProd.Text = "Los 10 productos mas vendidos";
        }

        private void bloquear_fechas()
        {
            DTDesde.Enabled = false;
            DTHasta.Enabled = false;
            LBuscar.Enabled = false;
        }

        private void RBTodo_CheckedChanged(object sender, EventArgs e)
        {
            bloquear_fechas();
            LTituloGrafCat.Text = "Las 5 categoria mas vendidas";
            LTituloGrafProd.Text = "Los 10 productos mas vendidos";
            graficarProductosMasVendidos();
            graficarCategoriaMasVendidas();
        }

        private void RBCategoria_CheckedChanged(object sender, EventArgs e)
        {
            bloquear_fechas();
            LTituloGrafCat.Text = "Las 5 categoria menos vendidas";
            LTituloGrafProd.Text = "Los 10 productos menos vendidos";
            graficarProductosMenosVendidos();
            graficarCategoriaMenosVendida();
        }

        private void mostrarTotales()
        {
            coneccion.Open();
            cmd = new SqlCommand("CantidadesDeCosas", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@totalVentas", 0);//0 para indircar que es entero
            total.Direction = ParameterDirection.Output;
            SqlParameter cantProd = new SqlParameter("@cadProd", 0);//0 para indircar que es entero
            cantProd.Direction = ParameterDirection.Output;
            SqlParameter cantCat = new SqlParameter("@canCateg", 0);//0 para indircar que es entero
            cantCat.Direction = ParameterDirection.Output;
            SqlParameter canMarca = new SqlParameter("@canMarca", 0);//0 para indircar que es entero
            canMarca.Direction = ParameterDirection.Output;
            SqlParameter canVen = new SqlParameter("@canVend", 0);//0 para indircar que es entero
            canVen.Direction = ParameterDirection.Output;
            SqlParameter canCli = new SqlParameter("@canCli", 0);//0 para indircar que es entero
            canCli.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(total);
            cmd.Parameters.Add(cantProd);
            cmd.Parameters.Add(cantCat);
            cmd.Parameters.Add(canMarca);
            cmd.Parameters.Add(canVen);
            cmd.Parameters.Add(canCli);
            cmd.ExecuteNonQuery();

            LTotal.Text = "$ " + cmd.Parameters["@totalVentas"].Value.ToString();
            LCantidadPro.Text = cmd.Parameters["@cadProd"].Value.ToString();
            LCantidadCat.Text = cmd.Parameters["@canCateg"].Value.ToString();
            LCantidadMar.Text = cmd.Parameters["@canMarca"].Value.ToString();
            LCantidadVentas.Text = cmd.Parameters["@canVend"].Value.ToString();
            LCantidadCli.Text = cmd.Parameters["@canCli"].Value.ToString();
            
            coneccion.Close();
        }

        private void graficarProductosMenosVendidos()
        {
            ArrayList producto = new ArrayList();
            ArrayList cant = new ArrayList();
            producto_fila = string.Empty;
            cmd = new SqlCommand("productosMenosVendidos", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            coneccion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                producto.Add(dr.GetString(1) + " " + dr.GetString(2));
                cant.Add(dr.GetInt32(4));
                producto_fila += "<tr>";
                producto_fila += "<td>" + Convert.ToString(dr.GetInt32(0)) + "</td>";
                producto_fila += "<td>" + dr.GetString(1) + "</td>";
                producto_fila += "<td>" + dr.GetString(2) + "</td>";
                producto_fila += "<td>" + dr.GetString(3) + "</td>";
                producto_fila += "<td>" + Convert.ToString(dr.GetInt32(4)) + "</td>";
                producto_fila += "</tr>";

            }
            chartProdPreferido.Series[0].Points.DataBindXY(producto, cant);
            dr.Close();
            coneccion.Close();
        }

        private void graficarCategoriaMenosVendida()
        {
            ArrayList categoria = new ArrayList();
            ArrayList cantProd = new ArrayList();
            cmd = new SqlCommand("CategoriaMenosVendida", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            coneccion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Add(dr.GetString(0));
                cantProd.Add(dr.GetInt32(1));
               
            }
            
            chartProdCategoria.Series[0].Points.DataBindXY(categoria, cantProd);
            dr.Close();
            coneccion.Close();
        }

        private void exportarImagen()
        {



        }

        private void BGenerarRep_Click(object sender, EventArgs e)
        {
            generarPdfMasPreferico();
            if (RBMasVendidos.Checked == true)
            {
                
            }
            if(RBMenosVendidos.Checked == true)
            {

            }
            if(RBFecha.Checked == true)
            {

            }
        }
        private void generarPdfMasPreferico()
        {

            string urlGraficoCategoria = "D:\\Documents\\Proyectos\\VIKINGO PROJECT\\VIKINGO PROJECT\\Graficos\\graficaCategoria.png";
            string urlGraficoProducto = "D:\\Documents\\Proyectos\\VIKINGO PROJECT\\VIKINGO PROJECT\\Graficos\\graficaProducto.png";

            SaveFileDialog save = new SaveFileDialog();
            string nombre_archivo = "Reporte" + "-" + DateTime.Now.ToString("ddMMyyyy") + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".pdf";
            save.FileName = nombre_archivo;

            string html = Properties.Resources.Planilla_de_reporte_estadistico.ToString(); //tiene el codigo de html
            

            //reemplaza parte de textos @ el parametro que se le pasa
            string fechaDesde = factura.obtenerFechaPrimerVenta();
            html = html.Replace("@FECHADESDE", fechaDesde);
            html = html.Replace("@FECHAIMPRECION", DateTime.Now.ToString("dd/MM/yyyy"));
            html = html.Replace("@FECHAHASTA", DateTime.Now.ToString("dd/MM/yyyy"));
            
            html = html.Replace("@TOTALVENDIDO", LTotalTitulo.Text);
            html = html.Replace("@NTOTAL", LTotal.Text);
            
            html = html.Replace("@TITULOPRODUCTOS", LTituloProc.Text);
            html = html.Replace("@NPRODUCTO", LCantidadPro.Text);

            html = html.Replace("@TITULOCATEGORIAS", LCantegoria.Text);
            html = html.Replace("@NCATEGORIA", LCantidadCat.Text);

            html = html.Replace("@TITULOMARCAS", LMarcas.Text);
            html = html.Replace("@NMARCA", LCantidadMar.Text);

            html = html.Replace("@TITULOVENTAS", LCantidadVendida.Text);
            html = html.Replace("@NVENTA", LCantidadVentas.Text);

            html = html.Replace("@TITULOCLIENTES", LCliente.Text);
            html = html.Replace("@NCLIENTE", LCantidadCli.Text);

            html = html.Replace("@ENCABEZADO", LTituloGrafCat.Text);
            html = html.Replace("@ENCABEZA3", LTituloGrafProd.Text);

            html = html.Replace("@LISTAENCABEZA2", LTituloGrafProd.Text);
            
            
            html = html.Replace("@FILAS", producto_fila);
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25); //caracteristica del documento
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); //nos permite escribir
                    pdfDoc.Open(); //abre el documento

                    //agregar logo
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_vikingo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img); //va a agregar la imagen con el formato que le dimos al pdf

                    //convertir el chart en imagen
                    chartProdCategoria.SaveImage(urlGraficoCategoria, ChartImageFormat.Png);
                    iTextSharp.text.Image imgCategoria = iTextSharp.text.Image.GetInstance(urlGraficoCategoria);
                    imgCategoria.ScaleToFit(250, 250);
                    imgCategoria.Alignment = iTextSharp.text.Image.UNDERLYING;
                    imgCategoria.SetAbsolutePosition(pdfDoc.LeftMargin + 10, pdfDoc.Top - 520);
                    pdfDoc.Add(imgCategoria); //va a agregar la imagen con el formato que le dimos al pdf


                    //convertir el chart en imagen
                    chartProdPreferido.SaveImage(urlGraficoProducto, ChartImageFormat.Png);
                    iTextSharp.text.Image imgProducto = iTextSharp.text.Image.GetInstance(urlGraficoProducto);
                    imgProducto.ScaleToFit(250, 250);
                    imgProducto.Alignment = iTextSharp.text.Image.UNDERLYING;
                    imgProducto.SetAbsolutePosition(pdfDoc.LeftMargin + 260, pdfDoc.Top - 450);
                    pdfDoc.Add(imgProducto); //va a agregar la imagen con el formato que le dimos al pdf

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr); //inserta el contenido del html en el pdf
                    }

                    string direccion = save.FileName; //obtenemos la direccion donde guardo
                    //borramos los graficos que se genero 
                    if (File.Exists(urlGraficoCategoria) && File.Exists(urlGraficoProducto))
                    {
                        try
                        {
                            File.Delete(urlGraficoCategoria);
                            File.Delete(urlGraficoProducto);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo problemas para eliminar los graficos", "Error en la eliminación de graficos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro la URL para almacenar los graficos", "Error de ubucación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pdfDoc.Close(); // cierra el documento
                    stream.Close(); // cierra el estilo de memoria

                    //ABRIR EL ARCHIVO
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = direccion;
                    proceso.Start();
                }

            }
        }

        private void LBuscar_Click(object sender, EventArgs e)
        {
            if (DTDesde.Value < DTHasta.Value)
            {
                //graficamos categorias
                ArrayList categoria = new ArrayList();
                ArrayList cantProd = new ArrayList();

                cmd = new SqlCommand("CategoriaMasVendidaPorFecha", coneccion);
                cmd.Parameters.AddWithValue("@fechaDesde", DTDesde.Value);
                cmd.Parameters.AddWithValue("@fechaHasta", DTHasta.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                coneccion.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categoria.Add(dr.GetString(0));
                    cantProd.Add(dr.GetInt32(1));

                }
                chartProdCategoria.Series[0].Points.DataBindXY(categoria, cantProd);
                dr.Close();
                coneccion.Close();

                producto_fila = string.Empty;
                ArrayList producto = new ArrayList();
                ArrayList cant = new ArrayList();

                cmd = new SqlCommand("productosPrefePorFecha", coneccion);
                cmd.Parameters.AddWithValue("@fechaDesde", DTDesde.Value);
                cmd.Parameters.AddWithValue("@fechaHasta", DTHasta.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                coneccion.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    producto.Add(dr.GetString(1) + " " + dr.GetString(2));
                    cant.Add(dr.GetInt32(4));
                    producto_fila += "<tr>";
                    producto_fila += "<td>" + Convert.ToString(dr.GetInt32(0)) + "</td>";
                    producto_fila += "<td>" + dr.GetString(1) + "</td>";
                    producto_fila += "<td>" + dr.GetString(2) + "</td>";
                    producto_fila += "<td>" + dr.GetString(3) + "</td>";
                    producto_fila += "<td>" + Convert.ToString(dr.GetInt32(4)) + "</td>";
                    producto_fila += "</tr>";
                }

                chartProdPreferido.Series[0].Points.DataBindXY(producto, cant);
                dr.Close();
                coneccion.Close();

            }
            else
            {
                MessageBox.Show("La fecha desde(primer campo) no puede ser mayor o igual que la fecha hasta(segundo campo)", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
