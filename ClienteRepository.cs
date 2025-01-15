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
    }
    
}
