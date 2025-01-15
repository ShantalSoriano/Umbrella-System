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

                // Agregar parámetros con los tipos de datos específicos
                comando.Parameters.Add("@nombreArticulo", SqlDbType.NVarChar).Value = articulo.nombreArticulo;
                comando.Parameters.Add("@cantidadArticulo", SqlDbType.Int).Value = articulo.cantidadArticulo;
                comando.Parameters.Add("@fechaAdquiArticulo", SqlDbType.DateTime).Value = articulo.fechaAdquiArticulo;

                // Si la fecha de vencimiento es null, insertarlo como DBNull.Value
                if (articulo.fechaVenciArticulo == null)
                {
                    comando.Parameters.Add("@fechaVenciArticulo", SqlDbType.DateTime).Value = DBNull.Value;
                }
                else
                {
                    comando.Parameters.Add("@fechaVenciArticulo", SqlDbType.DateTime).Value = articulo.fechaVenciArticulo;
                }

                comando.Parameters.Add("@descripcionArticulo", SqlDbType.NVarChar).Value = articulo.descripcionArticulo;
                comando.Parameters.Add("@idTipoArticulo", SqlDbType.Int).Value = articulo.idTipoArticulo;
                comando.Parameters.Add("@UnidadMedidaArticulo", SqlDbType.NVarChar).Value = articulo.UnidadMedidaArticulo;

                // Ejecutar el comando y obtener el número de filas afectadas
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

        public static Articulo ObtenerPorId(int idArticulo)
        {
            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "SELECT * FROM Inventario WHERE idArticulo = @idArticulo";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Add("@idArticulo", SqlDbType.Int).Value = idArticulo;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        idArticulo = reader.GetInt32(0),
                        nombreArticulo = reader.GetString(1),
                        cantidadArticulo = reader.GetInt32(2),
                        fechaAdquiArticulo = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                        fechaVenciArticulo = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        descripcionArticulo = reader.IsDBNull(5) ? null : reader.GetString(5),
                        idTipoArticulo = reader.GetInt32(6),
                        UnidadMedidaArticulo = reader.GetString(7)
                    };
                    return articulo;
                }
            }
            return null; // Si no se encuentra
        }

        public static int ActualizarArticulo(Articulo articulo)
        {
            int retorno = 0;

            using (SqlConnection conexion = DBConnection.ObtenerConexion())
            {
                string query = "UPDATE Inventario SET " +
                               "nombreArticulo = @nombreArticulo, " +
                               "cantidadArticulo = @cantidadArticulo, " +
                               "fechaAdquiArticulo = @fechaAdquiArticulo, " +
                               "fechaVenciArticulo = @fechaVenciArticulo, " +
                               "descripcionArticulo = @descripcionArticulo, " +
                               "idTipoArticulo = @idTipoArticulo, " +
                               "UnidadMedidaArticulo = @UnidadMedidaArticulo " +
                               "WHERE idArticulo = @idArticulo";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.Add("@nombreArticulo", SqlDbType.NVarChar).Value = articulo.nombreArticulo;
                comando.Parameters.Add("@cantidadArticulo", SqlDbType.Int).Value = articulo.cantidadArticulo;
                comando.Parameters.Add("@fechaAdquiArticulo", SqlDbType.DateTime).Value = articulo.fechaAdquiArticulo;

                if (articulo.fechaVenciArticulo == null)
                {
                    comando.Parameters.Add("@fechaVenciArticulo", SqlDbType.DateTime).Value = DBNull.Value;
                }
                else
                {
                    comando.Parameters.Add("@fechaVenciArticulo", SqlDbType.DateTime).Value = articulo.fechaVenciArticulo;
                }

                comando.Parameters.Add("@descripcionArticulo", SqlDbType.NVarChar).Value = articulo.descripcionArticulo;
                comando.Parameters.Add("@idTipoArticulo", SqlDbType.Int).Value = articulo.idTipoArticulo;
                comando.Parameters.Add("@UnidadMedidaArticulo", SqlDbType.NVarChar).Value = articulo.UnidadMedidaArticulo;
                comando.Parameters.Add("@idArticulo", SqlDbType.Int).Value = articulo.idArticulo;

                retorno = comando.ExecuteNonQuery(); // Retorna el número de filas afectadas
            }

            return retorno;
        }





    }
}
