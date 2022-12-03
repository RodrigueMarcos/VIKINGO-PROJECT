using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;

namespace VIKINGO_PROJECT.logica
{
    internal class LFactura
    {
        Factura factura = new Factura();
        CDFactura cdfactura = new CDFactura();
        Detalle detalle = new Detalle();
       /* public int agregarFactura(int p_cliente, int p_vendedor, int p_tipoFac, int p_formaPag, 
            decimal p_total, int p_descuento, int p_interez)
        {
            factura.id_cliente = p_cliente;
            factura.id_vendedor = p_vendedor;
            factura.id_tipoFactura = p_tipoFac;
            factura.id_formaPago = p_formaPag;
            factura.total = p_total;
            factura.descuento = p_descuento;
            factura.interez = p_interez;
            factura.fecha = DateTime.Now;
            return cdfactura.insertarFactura(factura);
        }

        public bool agregarDetalle(int p_idFactura, int p_idProducto, decimal p_precio, int p_cantidad)
        {
            detalle.id_factura = p_idFactura;
            detalle.id_producto = p_idProducto;
            detalle.precioUnitario = p_precio;
            detalle.cantidad = p_cantidad;
            return cdfactura.insertarDetalle(detalle);
        }*/

        public bool facturarVenta(int p_ID, int p_idCliente, int p_vendedor, int p_tipoFac, int p_formaPag,
            decimal p_total, DataGridView p_dgv)
        {
            factura.ID_factura = p_ID;
            factura.id_cliente = p_idCliente;
            factura.id_vendedor = p_vendedor;
            factura.id_tipoFactura = p_tipoFac;
            factura.id_formaPago = p_formaPag;
            factura.total = p_total;
            factura.fecha = DateTime.Now;

            return cdfactura.facturar(factura, p_dgv);
        }

        public void listarFacturasDelVendedor(int p_idVendedor,DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarFacturasIdVendedor(p_idVendedor);
            p_dgv.Columns["Vendedor"].Visible = false;
            p_dgv.Columns["Dni"].Visible = false;
        }
        public void listarDetalles(int id_factura,DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.enlistarDetalles(id_factura);
        }
        public void listarFacturasHoy(int p_id,DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarFacturasDeHoy(p_id);
        }
        public void listarFacturas(DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarfacturas();
            
        }
        public void listarFacturasPorCliente(string p_clienteNom,DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarFacturasCliente(p_clienteNom);
        }
        public void listarFacturasPorVendedor(int p_idVendedor, DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarFacturaPorVendedor(p_idVendedor);
        }

        public void listarFacturaPorFecha(DateTime p_desde, DateTime p_hasta, DataGridView p_dgv)
        {
            p_dgv.DataSource = cdfactura.listarFacturaPorFecha(p_desde, p_hasta);
        }

        public int buscarUltimoID()
        {
            return cdfactura.obtenerUltimaID();
        }
        public string obtenerFechaPrimerVenta()
        {
            return cdfactura.obtenerFechaPrimerVenta();
        }
    }
}
