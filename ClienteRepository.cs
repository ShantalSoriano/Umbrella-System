using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class ClienteRepository
    {
        public static int AgregarCliente(Cliente cliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "INSERT INTO Clientes (nombreCliente, telefonoCliente, direccionCliente) VALUES (@nombreCliente, @telefonoCliente, @direccionCliente);";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombreCliente", cliente.nombre);
                comando.Parameters.AddWithValue("@telefonoCliente", cliente.telefono);
                comando.Parameters.AddWithValue("@direccionCliente", cliente.direccion);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Cliente> ObtenerTodos()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "SELECT * FROM Clientes;";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = reader.GetInt32(0);
                    cliente.nombre = reader.GetString(1);
                    cliente.telefono = reader.GetString(2);
                    cliente.direccion = reader.GetString(3);
                    listaClientes.Add(cliente);
                }

                conexion.Close();
                return listaClientes;
            }
        }

        public int ActualizarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conexion = DBConnection.ObtenerConexion())
                {
                    string query = "UPDATE Clientes SET nombreCliente = @nombreCliente, telefonoCliente = @telefonoCliente, direccionCliente = @direccionCliente WHERE idCliente = @idCliente;";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombreCliente", cliente.nombre);
                    comando.Parameters.AddWithValue("@telefonoCliente", cliente.telefono);
                    comando.Parameters.AddWithValue("@direccionCliente", cliente.direccion);
                    comando.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                    {
                        MessageBox.Show("No se encontró un cliente con el ID proporcionado para actualizar.");
                    }
                    return filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el cliente: {ex.Message}");
                return -1; // Devuelve -1 en caso de error
            }
        }

    }
}
