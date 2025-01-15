using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class PrefServiciosRepository
    {
        private readonly string _connectionString;

        public PrefServiciosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para insertar una preferencia de servicio
        public void InsertarPreferencias(int idCliente, List<int> serviciosIds)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = "INSERT INTO PreferenciaServicio (IdCliente, IdServicio) VALUES (@IdCliente, @IdServicio)";
                        SqlCommand command = new SqlCommand(query, connection, transaction);

                        foreach (int idServicio in serviciosIds)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@IdCliente", idCliente);
                            command.Parameters.AddWithValue("@IdServicio", idServicio);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // Método para obtener las preferencias de un cliente
        public List<int> ObtenerServiciosPorCliente(int idCliente)
        {
            List<int> serviciosIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT IdServicio FROM PreferenciaServicio WHERE IdCliente = @IdCliente";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    serviciosIds.Add(reader.GetInt32(0));
                }
            }

            return serviciosIds;
        }
    }

}

