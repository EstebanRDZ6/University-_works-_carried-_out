using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=PecuTostadora3k\\SQLEXPRESS;Database=Empresa;User Id=sa;Password=123456;TrustServerCertificate=True;"
;        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener datos de las tablas relacionadas
                    string query = @"
                        SELECT 
                            e.ID_Empleado AS 'ID Empleado',
                            e.Nombre AS 'Nombre',
                            e.Apellido AS 'Apellido',
                            e.DNI AS 'DNI',
                            d.NombreDep AS 'Departamento',
                            p.NombreProyecto AS 'Proyecto'
                        FROM Empleado e
                        LEFT JOIN Departamento d ON e.ID_Empleado = d.ID_Empleado
                        LEFT JOIN Proyecto p ON d.ID_Proyecto = p.ID_Proyecto";

                    // Adaptador para llenar los datos en el DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Mostrar los datos en el DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
