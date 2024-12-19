using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using C2_110924.Persistencia;

namespace C2_110924.Negocio
{
    internal static class ProductosService
    {
        // Obtiene la ruta base de la aplicación
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        // Guarda un producto en el archivo
        public static void GuardarProducto(Producto unProducto)
        {
            try
            {
                string fileName = Path.Combine(GetAppPath(), "productos.txt");

                // Formato de datos a guardar
                string datos = $"{unProducto.ID};{unProducto.Nombre}";

                // Si el archivo no existe, lo crea. Si existe, agrega la línea.
                using (StreamWriter archivoSalida = new StreamWriter(fileName, append: true))
                {
                    archivoSalida.WriteLine(datos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el producto: " + ex.Message);
            }
        }

        // Lee productos desde el archivo
        public static List<Producto> LeerProductos()
        {
            string fileName = Path.Combine(GetAppPath(), "productos.txt");

            
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("El archivo de productos no existe.");
            }

            try
            {
                List<Producto> productos = new List<Producto>();

                string[] lineas = File.ReadAllLines(fileName);

                foreach (string productoComoTexto in lineas)
                {

                    var datos = productoComoTexto.Split(";");
                    if (datos.Length < 2)
                        continue; 

                    // Crear el producto
                    Producto unProducto = new Producto(datos[0], datos[1]);
                    productos.Add(unProducto);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer los productos: " + ex.Message);
            }
        }

        public static bool EliminarProductoPorID(int idProducto)
        {
            try
            {
                // Leer los productos desde el archivo
                var productos = LeerProductos();

                // Buscar el producto por ID (asegurando que ID sea del tipo string)
                var productoAEliminar = productos.FirstOrDefault(p => p.ID == idProducto.ToString());

                if (productoAEliminar != null)
                {
                    // Eliminar el producto de la lista
                    productos.Remove(productoAEliminar);

                    // Sobrescribir el archivo con la lista actualizada, guardando cada producto individualmente
                    // Primero vaciamos el archivo
                    File.Delete(Path.Combine(GetAppPath(), "productos.txt"));

                    // Guardar cada producto nuevamente en el archivo
                    foreach (var producto in productos)
                    {
                        GuardarProducto(producto);  // Guardamos cada producto individualmente
                    }

                    return true;
                }
                else
                {
                    return false; // Producto no encontrado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto. Detalles: {ex.Message}");
                return false;
            }
        }




    }
}

