using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.CDatos;
using VIKINGO_PROJECT.Entidad;

namespace VIKINGO_PROJECT.logica
{
    internal class LProducto
    {
        CDProductos producto = new CDProductos();
        Categoria categoria = new Categoria();

        public bool agregarCategoria(string p_categoria)
        {
            categoria.descripcion = p_categoria;
            if (producto.insertarCategoria(categoria))
            {
                return true;
            }
            else
            {
                return false;
            }
           /* try
            {
                
                int idCategoria = ;
                return true;
            }catch(Exception e)
            {
                MessageBox.Show("Hubo un error interno al intentar agregar la categoria!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            
            
            
        }

        public bool agregarMarca(string p_marca)
        {
            Marca marca = new Marca();
            marca.descripcion = p_marca;
            if (producto.insertarMarca(marca))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool agregarProducto(int p_codigo,string p_nombre,string p_descripcion,int p_categoria,int p_marca,int p_stockMin, int p_cantidad, decimal p_precio)
        {
            Producto objProducto = new Producto();
            objProducto.ID_producto = p_codigo;
            objProducto.nombre = p_nombre;
            objProducto.descripcion = p_descripcion;
            objProducto.id_categoria = p_categoria;
            objProducto.id_marca = p_marca;
            objProducto.stock_minimo = p_stockMin;
            objProducto.stock_actual = p_cantidad;
            objProducto.precio = p_precio;

            if (producto.insertarProducto(objProducto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarListaProducto(DataGridView p_dgv)
        {
            p_dgv.DataSource = producto.getProductosAll();
            
            p_dgv.Columns["ID_categoria"].Visible = false;
            p_dgv.Columns["ID_marca"].Visible = false;

        }
        public void buscarProductoCodigo (string p_codigo, DataGridView p_dgv)
        {
            p_dgv.DataSource = producto.filtrarProductoCodigo(p_codigo);

        }
        public void buscarProductoNombre(string p_codigo, DataGridView p_dgv)
        {
            p_dgv.DataSource = producto.filtrarProductoNombre(p_codigo);

        }
        public bool modificarProducto(int p_codigo, string p_nombre, string p_descripcion, int p_categoria, int p_marca, int p_stockMin, int p_cantidad, decimal p_precio)
        {
            Producto objProducto = new Producto();
            objProducto.ID_producto = p_codigo;
            objProducto.nombre = p_nombre;
            objProducto.descripcion = p_descripcion;
            objProducto.id_categoria = p_categoria;
            objProducto.id_marca = p_marca;
            objProducto.stock_minimo = p_stockMin;
            objProducto.stock_actual = p_cantidad;
            objProducto.precio = p_precio;

            if (producto.actualizarProducto(objProducto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool darDeBaja(int p_codigo, int p_cantidad,string p_motivo)
        {
            prodDefectuoso objeto = new prodDefectuoso();
            objeto.idProducto = p_codigo;
            objeto.cantidad = p_cantidad;
            objeto.fecha = DateTime.Now;
            objeto.motivo = p_motivo;
            return producto.darDeBajaProducto(objeto);
        }
        public void listarProductosFaltantes(DataGridView p_dgv)
        {
            
            p_dgv.DataSource = producto.obtenerProductosFaltantes();
            p_dgv.Columns["ID_categoria"].Visible = false;
            p_dgv.Columns["ID_marca"].Visible = false;
        }

        public int obtenerStockProducto(int p_codigo)
        {
            return producto.obtenerStockActualPro(p_codigo);
        }
    }
}
