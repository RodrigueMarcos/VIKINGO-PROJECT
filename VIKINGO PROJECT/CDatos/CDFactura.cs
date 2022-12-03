using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.CDatos
{
    internal class CDFactura
    {
        VIKINGO baseDatos = new VIKINGO();

        /*public int insertarFactura(Factura p_factura)
        {
            try
            {
                baseDatos.Factura.Add(p_factura);
                baseDatos.SaveChanges();
                return p_factura.ID_factura;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }
        public bool insertarDetalle(Detalle p_detalle)
        {
            try
            {
                baseDatos.Detalle.Add(p_detalle);
                baseDatos.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }*/
        public bool facturar(Factura p_factura,DataGridView p_dgv)
        {
            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {
                    baseDatos.Factura.Add(p_factura);
                    //baseDatos.SaveChanges();
                    //int id_factura= p_factura.ID_factura;
                    //int cantidad;
                    //int codigoProducto;
                    //decimal precioUnitario;
                    Detalle detalle;

                    for (int i = 0; i < p_dgv.Rows.Count; i++)
                    {
                        detalle = new Detalle();
                        detalle.id_factura = p_factura.ID_factura;
                        detalle.cantidad = Convert.ToInt32(p_dgv.Rows[i].Cells["Cantidad"].Value);
                        detalle.id_producto = Convert.ToInt32(p_dgv.Rows[i].Cells["ID_producto"].Value);
                        detalle.precioUnitario = Convert.ToDecimal(p_dgv.Rows[i].Cells["Precio_unitario"].Value);
                        baseDatos.Detalle.Add(detalle);
                        
                    }
                    baseDatos.SaveChanges();
                    transaccion.Commit();
                    return true;    
                } catch (Exception)
                {
                    transaccion.Rollback();
                    return false;
                }
            }
        }
        public List<FacturaCompleta> listarFacturasIdVendedor(int p_id)
        {
            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            where f.id_vendedor == p_id
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " "+v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }
        public List<DetalleCompleto> enlistarDetalles(int p_id_factura)
        {
            var consulta = (from d in baseDatos.Detalle
                            join p in baseDatos.Producto on d.id_producto equals p.ID_producto
                            where d.id_factura == p_id_factura
                            select new DetalleCompleto
                            {
                                Codigo = (int)d.id_producto,
                                Producto = p.nombre,
                                Descripcion = p.descripcion,
                                Cantidad = d.cantidad,
                                Precio_Unitario = d.precioUnitario,
                                Sub_Total = (d.cantidad * d.precioUnitario)
                            }).ToList();
            return consulta;
        }
        public List<FacturaCompleta> listarFacturasDeHoy(int p_id)
        {
            DateTime hoy = DateTime.Today;

            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            where f.id_vendedor == p_id && EntityFunctions.TruncateTime(f.fecha) == DateTime.Today
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " " + v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }
        public List<FacturaCompleta> listarfacturas()
        {
            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " " + v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }

        public List<FacturaCompleta> listarFacturasCliente(string p_clienteNom)
        {
            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            where p.apellido.StartsWith(p_clienteNom)
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " " + v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }
        public List<FacturaCompleta> listarFacturaPorVendedor(int p_idVendedor)
        {
            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            where f.id_vendedor == p_idVendedor
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " " + v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }
        public List<FacturaCompleta> listarFacturaPorFecha(DateTime p_desde, DateTime p_hasta)
        {
            var consulta = (from f in baseDatos.Factura
                            join p in baseDatos.Persona on f.id_cliente equals p.ID_persona
                            join tf in baseDatos.TipoFactura on f.id_tipoFactura equals tf.ID_tipoFactura
                            join fp in baseDatos.FormaPago on f.id_formaPago equals fp.ID_formaPago
                            join v in baseDatos.Persona on f.id_vendedor equals v.ID_persona
                            where f.fecha >= p_desde && f.fecha <= p_hasta
                            select new FacturaCompleta
                            {
                                ID_Factura = f.ID_factura,
                                Dni = p.DNI,
                                Cliente = p.apellido + " " + p.nombre,
                                Vendedor = v.apellido + " " + v.nombre,
                                Tipo_Factura = tf.descripcion,
                                Forma_De_Pago = fp.descripcion,
                                Total = f.total,
                                Fecha = f.fecha
                            }).ToList();
            return consulta;
        }

        public int obtenerUltimaID()
        {
            try
            {
                int consulta = (from f in baseDatos.Factura
                                orderby f.ID_factura descending
                                select f.ID_factura).ToList().First();
                return consulta;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }
        public string obtenerFechaPrimerVenta()
        {
            try
            {
                var consulta = (from f in baseDatos.Factura
                                orderby f.fecha ascending
                                select f.fecha).ToList().First().ToString("dd/MM/yyyy");
                return consulta;
            }
            catch
            {
                return "01/01/1900";
            }
            
        }
    }
}
