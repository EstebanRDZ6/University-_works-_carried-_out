using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using C2_110924.Persistencia;

namespace C2_110924.Negocio
{
    internal class MovimientosService
    {
        // Obtiene la ruta base de la aplicación
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        // Guarda un movimiento en el archivo
        public static void GuardarMovimiento(Movimiento unMovimiento, string idProducto)
        {
            try
            {
                string fileName = Path.Combine(GetAppPath(), "movimientos.txt");

                string datos = $"{unMovimiento.Id};{unMovimiento.Cantidad};{unMovimiento.Fecha:yyyy-MM-dd};{idProducto}";

                // Si el archivo no existe, lo crea. Si existe, agrega la línea.
                using (StreamWriter archivoSalida = new StreamWriter(fileName, append: true))
                {
                    archivoSalida.WriteLine(datos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el movimiento: " + ex.Message);
            }
        }

        // Obtiene movimientos de un producto
        public static List<Movimiento> ObtenerMovimientosProducto(Producto unProducto)
        {
            string fileName = Path.Combine(GetAppPath(), "movimientos.txt");

            // Si el archivo no existe, lo crea vacío
            if (!File.Exists(fileName))
            {
                using (File.Create(fileName))
                {
                    // El archivo se crea vacío y se cierra automáticamente.
                }
            }

            try
            {
                List<Movimiento> movimientos = new List<Movimiento>();
                string[] lineas = File.ReadAllLines(fileName);

                foreach (string movimientoComoTexto in lineas)
                {
                    var datos = movimientoComoTexto.Split(";");
                    if (datos.Length < 4)
                        continue;

                    if (unProducto.ID == datos[3])
                    {
                        int cantidad = int.Parse(datos[1]);
                        DateTime fecha = DateTime.Parse(datos[2]);

                        Movimiento unMovimiento = new Movimiento(datos[0], cantidad, fecha);
                        movimientos.Add(unMovimiento);
                    }
                }

                return movimientos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer los movimientos: " + ex.Message);
            }
        }
    }
}
