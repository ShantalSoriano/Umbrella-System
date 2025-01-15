using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_System
{
    public class DBConnection
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-HNT4E4U\SQLEXPRESS;Initial Catalog=UmbrellaSystemDB;Integrated Security=True;Trust Server Certificate=True");
            Conexion.Open();

            return Conexion;
        }
    }
}
