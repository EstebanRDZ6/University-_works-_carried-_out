using C2_110924.Negocio;
using C2_110924.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924.Controladores
{
    internal static class ProductosController
    {
        // Este es nuestro controlador del negocio
        public static void GuardarProducto(Producto unProducto)
        {
            if (unProducto == null)
                throw new ArgumentNullException(nameof(unProducto), "El producto no puede ser nulo.");

            ProductosService.GuardarProducto(unProducto);
        }

        public static List<Producto> CargarMovimientos(List<Producto> productos)
        {
            if (productos == null || productos.Count == 0)
                return new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto == null) continue;

                List<Movimiento> listaMovimientos = MovimientosService.ObtenerMovimientosProducto(producto) ?? new List<Movimiento>();
                if (listaMovimientos.Count > 0)
                {
                    producto.CargarMovimientos(listaMovimientos);
                }
            }
            return productos;
        }

        public static List<Producto> LeerProductos()
        {
            try
            {
                List<Producto> productos = ProductosService.LeerProductos() ?? new List<Producto>();
                if (productos != null && productos.Count > 0)
                {
                    productos = CargarMovimientos(productos);
                }
                return productos; // Devuelve la lista cargada.
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer productos: " + ex.Message, ex);
            }
        }



        public static void AgregarMovimiento(Producto unProducto, Movimiento unMovimiento)
        {
            if (unProducto == null)
                throw new ArgumentNullException(nameof(unProducto), "El producto no puede ser nulo.");
            if (unMovimiento == null)
                throw new ArgumentNullException(nameof(unMovimiento), "El movimiento no puede ser nulo.");

            unProducto.CargarMovimientos(new List<Movimiento> { unMovimiento });
            MovimientosService.GuardarMovimiento(unMovimiento, unProducto.ID);
        }

    }
}

