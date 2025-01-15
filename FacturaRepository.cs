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
                using (SqlConnection connection = DBConnection.ObtenerConexion())
                {
                    string query = "INSERT INTO Facturas (fechaFactura, totalFactura, idCliente) OUTPUT INSERTED.idFactura VALUES (@fechaFactura, @totalFactura, @idCliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fechaFactura", factura.FechaFactura);
                    command.Parameters.AddWithValue("@totalFactura", factura.TotalFactura);
                    command.Parameters.AddWithValue("@idCliente", factura.IdCliente);

                    connection.Open();
                    int idFactura = (int)command.ExecuteScalar(); // Obtener el ID de la factura insertada
                    return idFactura;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with your logging mechanism)
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


    }

}
