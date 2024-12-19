using System;
using System.Windows.Forms;

namespace C2_110924
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura el entorno de la aplicaci�n
            ApplicationConfiguration.Initialize();

            // Manejo global de excepciones no controladas
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception)args.ExceptionObject;
                MessageBox.Show($"Error no controlado: {ex.Message}", "Error Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show($"Error en la interfaz: {args.Exception.Message}", "Error Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Ejecuta la aplicaci�n dentro de un bloque using para manejar recursos
            using (Form1 mainForm = new Form1())
            {
                Application.Run(mainForm);
            }
        }
    }
}
