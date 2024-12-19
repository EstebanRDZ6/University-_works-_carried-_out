using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Aeropuerto19
{
    internal class AvionDataBase
    {
        private string connectionString = "Data Source=PecuTostadora3k\\SQLEXPRESS;Initial Catalog=Aeropuerto19;User ID=sa;Password=123456;TrustServerCertificate=True;";

        // Método para conectar a la base de datos
        private SqlConnection Connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                return null;
            }
        }

        // Método para obtener la lista de aviones
        public List<Avion> ObtenerAviones()
        {
            List<Avion> aviones = new List<Avion>();
            string query = "SELECT * FROM Avion";

            try
            {
                // Usar el método Connect() y asegurarse de que conn no sea null antes de proceder.
                using (var conn = Connect())
                {
                    if (conn == null)
                    {
                        // Si la conexión es null, retorna una lista vacía, nunca null.
                        return aviones;
                    }

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                aviones.Add(new Avion
                                {
                                    Id = reader.GetInt32(0),
                                    Modelo = reader.GetString(1),
                                    TipoDeNave = reader.GetString(2),
                                    Matricula = reader.GetString(3),
                                    CapacidadPasajeros = reader.GetInt32(4),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener aviones: " + ex.Message);
            }

            // Retornar siempre la lista (aunque esté vacía).
            return aviones;
        }


        // Método para insertar un nuevo avión
        public void InsertarAvion(Avion avion)
        {
            string query = "INSERT INTO Avion (Id, Modelo, TipoDeNave, Matricula, CapacidadPasajeros) " +
                           "VALUES (@Id, @Modelo, @TipoDeNave, @Matricula, @CapacidadPasajeros)";

            try
            {
                using (var conn = Connect())
                {
                    if (conn == null) return;

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", avion.Id);
                        cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                        cmd.Parameters.AddWithValue("@TipoDeNave", avion.TipoDeNave);
                        cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                        cmd.Parameters.AddWithValue("@CapacidadPasajeros", avion.CapacidadPasajeros);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el avión: " + ex.Message);
            }
        }

        // Método para eliminar un avión por ID
        public void EliminarAvion(int id)
        {
            string query = "DELETE FROM Avion WHERE Id = @Id";

            try
            {
                using (var conn = Connect())
                {
                    if (conn == null) return;

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el avión: " + ex.Message);
            }
        }

        // Método para modificar un avión existente
        public void ModificarAvion(Avion avion)
        {
            string query = "UPDATE Avion SET Modelo = @Modelo, TipoDeNave = @TipoDeNave, " +
                           "Matricula = @Matricula, CapacidadPasajeros = @CapacidadPasajeros " +
                           "WHERE Id = @Id";

            try
            {
                using (var conn = Connect())
                {
                    if (conn == null) return;

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", avion.Id);
                        cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                        cmd.Parameters.AddWithValue("@TipoDeNave", avion.TipoDeNave);
                        cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                        cmd.Parameters.AddWithValue("@CapacidadPasajeros", avion.CapacidadPasajeros);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el avión: " + ex.Message);
            }
        }
    }
}
