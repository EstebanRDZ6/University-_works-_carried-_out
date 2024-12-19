using System.Net;

namespace Ejercicio_grupo_12___FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtArchivoLocal.Text))
            {
                SubirArchivoFTP(txtArchivoLocal.Text, txtFTPUrl.Text, txtFTPUsuario.Text, txtFTPContraseña.Text);
            }
            else
            {
                MessageBox.Show("El archivo no existe. Por favor, verifica la ruta.", "Error");
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtArchivoNombre.Text))
            {
                DescargarArchivoFTP(txtArchivoNombre.Text, txtFTPUrl.Text, txtArchivoLocal.Text, txtFTPUsuario.Text, txtFTPContraseña.Text);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el nombre del archivo a descargar.", "Error");
            }
        }

        private void btnGuardarLogs_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "logs.txt";
            List<string> logs = lstLogs.Items.Cast<string>().ToList();

            LogManager.GuardarLogsEnArchivo(rutaArchivo, logs);
            MessageBox.Show($"Logs guardados en: {rutaArchivo}", "Éxito");
        }
        private void SubirArchivoFTP(string rutaArchivo, string urlServidor, string usuario, string contraseña)
        {
            try
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                string urlCompleta = $"{urlServidor}/{nombreArchivo}";

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(urlCompleta);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(usuario, contraseña);

                byte[] archivoBytes = File.ReadAllBytes(rutaArchivo);
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(archivoBytes, 0, archivoBytes.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    string log = LogManager.GenerarLog("CARGA", nombreArchivo);
                    lstLogs.Items.Add(log);
                    MessageBox.Show($"Archivo subido correctamente: {response.StatusDescription}", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al subir el archivo: {ex.Message}", "Error");
            }
        }
        private void DescargarArchivoFTP(string nombreArchivo, string urlServidor, string rutaDestino, string usuario, string contraseña)
        {
            try
            {
                string urlCompleta = $"{urlServidor}/{nombreArchivo}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(urlCompleta);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(usuario, contraseña);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(rutaDestino, FileMode.Create))
                {
                    responseStream.CopyTo(fileStream);
                }

                string log = LogManager.GenerarLog("DESCARGA", nombreArchivo);
                lstLogs.Items.Add(log);
                MessageBox.Show("Archivo descargado correctamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al descargar el archivo: {ex.Message}", "Error");
            }
        }

    }
}
