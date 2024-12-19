using System;
using System.Windows.Forms;

namespace C2_110924
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura el entorno de la aplicación
            ApplicationConfiguration.Initialize();

            // Manejo global de excepciones no controladas
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception)args.ExceptionObject;
                MessageBox.Show($"Error no controlado: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show($"Error en la interfaz: {args.Exception.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Ejecuta la aplicación dentro de un bloque using para manejar recursos
            using (Form1 mainForm = new Form1())
            {
                Application.Run(mainForm);
            }
        }
    }
}
