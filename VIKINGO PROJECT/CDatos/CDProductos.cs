using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIKINGO_PROJECT.Entidad;
using VIKINGO_PROJECT.logica;

namespace VIKINGO_PROJECT.CDatos
{
    

    internal class CDProductos
    {
        VIKINGO baseDatos = new VIKINGO();
        public bool insertarCategoria(Categoria p_categoria)
        {
            try
            {
                baseDatos.Categoria.Add(p_categoria);
                baseDatos.SaveChanges();
                return true;    
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool insertarMarca(Marca p_marca)
        {
            try
            {
                baseDatos.Marca.Add(p_marca);
                baseDatos.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool insertarProducto(Producto p_producto)
        {
            try
            {
                baseDatos.Producto.Add(p_producto);
                baseDatos.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<ProductoCompleto> getProductosAll()
        {
            var consulta = (from p in baseDatos.Producto
                            join c in baseDatos.Categoria on p.id_categoria equals c.ID_categoria
                            join m in baseDatos.Marca on p.id_marca equals m.ID_marca
                            select new ProductoCompleto
                            {
                                Codigo = p.ID_producto,
                                Nombre = p.nombre,
                                Descripcion = p.descripcion,
                                ID_categoria = p.id_categoria,
                                Categoria_des = c.descripcion,
                                ID_Marca = p.id_marca,
                                Marca_des = m.descripcion,
                                Stock_actual = (int)p.stock_actual,
                                Stock_minimo = (int)p.stock_minimo,
                                Precio = (decimal)p.precio
                            }).ToList();
            return consulta;
        }

        public List<ProductoCompleto> filtrarProductoCodigo(string p_codigo)
        {
            var consulta = (from p in baseDatos.Producto
                            join c in baseDatos.Categoria on p.id_categoria equals c.ID_categoria
                            join m in baseDatos.Marca on p.id_marca equals m.ID_marca
                            where p.ID_producto.ToString().StartsWith(p_codigo)
                            select new ProductoCompleto
                            {
                                Codigo = p.ID_producto,
                                Nombre = p.nombre,
                                Descripcion = p.descripcion,
                                ID_categoria = p.id_categoria,
                                Categoria_des = c.descripcion,
                                ID_Marca = p.id_marca,
                                Marca_des = m.descripcion,
                                Stock_actual = (int)p.stock_actual,
                                Stock_minimo = (int)p.stock_minimo,
                                Precio = (decimal)p.precio
                            }).ToList();
            return consulta;
        }
       
        public List<ProductoCompleto> filtrarProductoNombre(string p_codigo)
        {
            var consulta = (from p in baseDatos.Producto
                            join c in baseDatos.Categoria on p.id_categoria equals c.ID_categoria
                            join m in baseDatos.Marca on p.id_marca equals m.ID_marca
                            where p.nombre.StartsWith(p_codigo)
                            select new ProductoCompleto
                            {
                                Codigo = p.ID_producto,
                                Nombre = p.nombre,
                                Descripcion = p.descripcion,
                                ID_categoria = p.id_categoria,
                                Categoria_des = c.descripcion,
                                ID_Marca = p.id_marca,
                                Marca_des = m.descripcion,
                                Stock_actual = (int)p.stock_actual,
                                Stock_minimo = (int)p.stock_minimo,
                                Precio = (decimal)p.precio
                            }).ToList();
            return consulta;
        }

        public bool actualizarProducto(Producto p_producto)
        {
            try
            {
                baseDatos.Entry(p_producto).State = EntityState.Modified;
                
                baseDatos.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool darDeBajaProducto(prodDefectuoso p_producto)
        {
            try
            {
                baseDatos.prodDefectuoso.Add(p_producto);
                baseDatos.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }public List<ProductoCompleto> obtenerProductosFaltantes()
        {
            var consulta = (from p in baseDatos.Producto
                            join c in baseDatos.Categoria on p.id_categoria equals c.ID_categoria
                            join m in baseDatos.Marca on p.id_marca equals m.ID_marca
                            where p.stock_minimo > p.stock_actual
                            select new ProductoCompleto
                            {
                                Codigo = p.ID_producto,
                                Nombre = p.nombre,
                                Descripcion = p.descripcion,
                                ID_categoria = p.id_categoria,
                                Categoria_des = c.descripcion,
                                ID_Marca = p.id_marca,
                                Marca_des = m.descripcion,
                                Stock_actual = (int)p.stock_actual,
                                Stock_minimo = (int)p.stock_minimo,
                                Precio = (decimal)p.precio
                            }).ToList();
            return consulta;
        }
        public int obtenerStockActualPro(int p_codigo)
        {
            try
            {
                var consulta = (from p in baseDatos.Producto
                                where p.ID_producto == p_codigo
                                select (int)p.stock_actual).ToList().First();
                return consulta;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error interno no se encontro el producto seleccionado", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
