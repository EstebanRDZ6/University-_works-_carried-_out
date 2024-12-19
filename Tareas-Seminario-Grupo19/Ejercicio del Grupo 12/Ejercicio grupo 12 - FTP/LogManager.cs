using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_grupo_12___FTP
{
    public class LogManager
    {
        public static void GuardarLogsEnArchivo(string rutaArchivo, List<string> logs)
        {
            File.WriteAllLines(rutaArchivo, logs);
        }

        public static string GenerarLog(string operacion, string nombreArchivo)
        {
            return $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}]  [{operacion}]  [{nombreArchivo}]";
        }
    }

}
