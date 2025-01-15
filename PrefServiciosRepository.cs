using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class Servicios
    {
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
    }

    public class PrefServiciosRepository
    {
        public static List<Servicios> CargarServicios()
        {
            List<Servicios> servicios = new List<Servicios>();

            try
            {
                using (SqlConnection connection = DBConnection.ObtenerConexion())
                {
                    connection.Open();

                    string query = "SELECT IdServicio, NombreServicio FROM Servicios";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idServicio = reader.GetInt32(0);
                        string nombreServicio = reader.GetString(1);

                        // Crear un objeto Servicio y agregarlo a la lista
                        Servicios servicio = new Servicios
                        {
                            IdServicio = idServicio,
                            NombreServicio = nombreServicio
                        };
                        servicios.Add(servicio);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios: " + ex.Message);
            }

            return servicios;
        }
    }
}
