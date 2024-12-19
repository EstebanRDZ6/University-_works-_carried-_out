using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Conexion_y_seguridad_Base_de_Datos
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=servidorpeliculas.database.windows.net;Database=Peliculas;User Id=adminsql;Password=Seminario2;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar abrir la conexi�n
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexi�n
                    listBoxLogs.Items.Add("[�xito] Conexi�n exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexi�n
                listBoxLogs.Items.Add($"[Error] No se pudo conectar: {ex.Message}");
            }
        }
    }
}
