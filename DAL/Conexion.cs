using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPGMeet.DAL
{
        public class Conexion
    {
        private static Conexion instance = null;
        public SqlConnection Connection { get; }

        private static String dataSource = "Data Source=185.253.153.20,54321;";
        private static String initialCatalog = "Initial Catalog=ManuelRPG;";
        private static String user = "User ID=sa;";
        private static String pass = "Password=123456789;";

        private String cadenaConexion = dataSource + initialCatalog + user + pass;
        private String connectionString = "Data Source=185.253.153.20,54321;Initial Catalog=ManuelAlvarezEmployees;User ID=sa;Password=123456789;";



        public Conexion()
        {
            Connection = new SqlConnection(cadenaConexion);
        }
        public static Conexion Instance()
        {
            if (instance == null)
            {
                instance = new Conexion();
                
            }
            return instance;
        }
    }
}
