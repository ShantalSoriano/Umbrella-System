using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class FacturaRepository
    {
        // Método para crear una nueva factura y devolver el Id de la factura creada
        public int CrearFactura(Factura factura)
        {
            try
            {
                using (SqlConnection connection = DBConnection.ObtenerConexion()) // Asegúrate de que el using esté aquí
                {
                    string query = "INSERT INTO Facturas (fechaFactura, totalFactura, idCliente) OUTPUT INSERTED.idFactura VALUES (@fechaFactura, @totalFactura, @idCliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fechaFactura", factura.FechaFactura);
                    command.Parameters.AddWithValue("@totalFactura", factura.TotalFactura);
                    command.Parameters.AddWithValue("@idCliente", factura.IdCliente);

                     // Asegúrate de abrir la conexión solo si está cerrada

                    int idFactura = (int)command.ExecuteScalar(); // Obtener el ID de la factura insertada
                    return idFactura;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }



        // Método para obtener todas las facturas
        public List<Factura> ObtenerFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            try
            {
                using (SqlConnection connection = DBConnection.ObtenerConexion())
                {
                    string query = "SELECT idFactura, fechaFactura, totalFactura, idCliente FROM Facturas";
                    SqlCommand command = new SqlCommand(query, connection);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Factura factura = new Factura
                            {
                                IdFactura = (int)reader["idFactura"],
                                FechaFactura = (DateTime)reader["fechaFactura"],
                                TotalFactura = (decimal)reader["totalFactura"],
                                IdCliente = (int)reader["idCliente"]
                            };
                            facturas.Add(factura);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with your logging mechanism)
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }

            return facturas;
        }

        public void GuardarServicioFactura(int idFactura, int idServicio, int cantidad, decimal subtotal)
        {
            try
            {
                using (SqlConnection connection = DBConnection.ObtenerConexion()) // Asegúrate de que el using esté aquí
                {
                    string query = "INSERT INTO ServiciosFacturados (idFactura, idServicio, cantidad, subtotal) VALUES (@idFactura, @idServicio, @cantidad, @subtotal)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idFactura", idFactura);
                    command.Parameters.AddWithValue("@idServicio", idServicio);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@subtotal", subtotal);

                    connection.Open(); // Asegúrate de abrir la conexión solo si está cerrada

                    command.ExecuteNonQuery();  // Ejecutar la inserción en la base de datos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el servicio: {ex.Message}");
                throw;
            }
        }



    }
}
