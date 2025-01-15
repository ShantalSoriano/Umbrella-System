using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class ArticuloRepository
    {
        public static int AddArticulo(Articulo articulo)
        {
            int retorno = 0;
            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "INSERT INTO Inventario (nombreArticulo, cantidadArticulo, fechaAdquiArticulo, fechaVenciArticulo, descripcionArticulo, idTipoArticulo, UnidadMedidaArticulo) " +
                       "VALUES (@nombreArticulo, @cantidadArticulo, @fechaAdquiArticulo, @fechaVenciArticulo, @descripcionArticulo, @idTipoArticulo, @UnidadMedidaArticulo);";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombreArticulo", articulo.nombreArticulo);
                comando.Parameters.AddWithValue("@cantidadArticulo", articulo.cantidadArticulo);
                comando.Parameters.AddWithValue("@fechaAdquiArticulo", articulo.fechaAdquiArticulo); // Fecha de adquisición
                comando.Parameters.AddWithValue("@fechaVenciArticulo", articulo.fechaVenciArticulo); // Fecha de vencimiento
                comando.Parameters.AddWithValue("@descripcionArticulo", articulo.descripcionArticulo);
                comando.Parameters.AddWithValue("@idTipoArticulo", articulo.idTipoArticulo);
                comando.Parameters.AddWithValue("@UnidadMedidaArticulo", articulo.UnidadMedidaArticulo);
                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Articulo> ObtenerTodos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "SELECT * FROM Inventario;";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.idArticulo = reader.GetInt32(0);
                    articulo.nombreArticulo = reader.GetString(1);
                    articulo.cantidadArticulo = reader.GetInt32(2);
                    articulo.fechaAdquiArticulo = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    articulo.fechaVenciArticulo = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    articulo.descripcionArticulo = reader.IsDBNull(5) ? null : reader.GetString(5);
                    articulo.idTipoArticulo = reader.GetInt32(6);
                    articulo.UnidadMedidaArticulo = reader.GetString(7);
                    listaArticulos.Add(articulo);
                }
               
            }
            return listaArticulos;
        }

        public static List<TipoArticulo> ObtenerTiposArticulo()
        {
            List<TipoArticulo> tiposArticulo = new List<TipoArticulo>();

            // Usamos el procedimiento almacenado SP_CMBTIPOARTICULO
            using (SqlConnection conexion = DBConnection.ObtenerConexion()) 
            {
                SqlCommand command = new SqlCommand("SP_CMBTIPOARTICULO", conexion);
                command.CommandType = CommandType.StoredProcedure; // procedimiento almacenado aqui

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposArticulo.Add(new TipoArticulo
                        {
                            IdTipoArticulo = Convert.ToInt32(reader["idTipoArticulo"]),
                            NombreTipo = reader["nombreTipo"].ToString()
                        });
                    }
                }
            }

            return tiposArticulo;
        }

       

    }
}
