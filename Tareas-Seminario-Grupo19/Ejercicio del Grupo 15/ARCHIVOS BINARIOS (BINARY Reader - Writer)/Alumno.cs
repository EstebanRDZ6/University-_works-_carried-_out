using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVOS_BINARIOS__BINARY_Reader___Writer_
{
    [Serializable]
    public class Alumno
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }

        // Constructor para inicializar el Alumno
        public Alumno(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            DNI = dni;
            Telefono = telefono;
        }

        // Método para convertir el Alumno a string para mostrar en ListBox
        public override string ToString()
        {
            return $"Nombre: {Nombre}, DNI: {DNI}, Teléfono: {Telefono}";
        }
    }

}
