
using BackRPG.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BackRPG.DAO
{

    /*
    - CREAR PARA VER TODOS LOS USUARIOS  --- SelectAll()
    - CREAR PARA LOGIN 
    - CREAR PARA INSERTAR UN USUARIO
    - CREAR PARA MODIFICAR DATOS DE USUARIO CUANDO SU ID SEA ?? 
    - CREAR PARA MODIFICAR EL PASSWORD CUANDO SU ID SEA ?? Y EL PASSQORD SEA EL ANTIGUO 
    - CREAR PARA ELIMINAR UN USUARIO CUANDO LA ID SEA ?? 
    
    - CREAR PARA VER TODAS LAS PARTIDASQUE HA CREADO UN USUARIO CUANDO LA ID SEA ?? 
    - CREAR PARA VER TODAS LAS HISTORIAS DE UN USUARIO CUANDO LA ID SEA ?? 
     */
    public static class DalUsuario
    {
        private static String dataSource = "Data Source=185.253.153.20,54321;";
        private static String initialCatalog = "Initial Catalog=ManuelRPG;";
        private static String user = "User ID=sa;";
        private static String pass = "Password=123456789;";

        private static String cadenaConexion = dataSource + initialCatalog + user + pass;
        
        // todo lo de arriba es el objeto conection 
        public static Usuario ReaderUsuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.IdUsuario = (int)reader["IdUsuario"];
            usuario.Email = reader["Email"].ToString();
            usuario.Pass = reader["Pass"].ToString();
            usuario.Username = reader["Username"].ToString();
            usuario.FKLocalidad = !reader.IsDBNull(reader.GetOrdinal("FKLocalidad")) ? (int)reader["FKLocalidad"] : (int?)null;
            usuario.FKFotoPerfil = !reader.IsDBNull(reader.GetOrdinal("FKFotoPerfil")) ? (int)reader["FKFotoPerfil"] : (int?)null;

            return usuario;
        }

        /// <summary>
        ///  Metodo que te devuelve todos los Usuarios de la tabla en un List<Usuario>
        /// </summary>
        public static List<Usuario> SelectAll()
        {
            //Conexion cn = Conexion.Instance();
            String query = "SELECT * FROM usuario";
            List<Usuario> list = new List<Usuario>();

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try 
            {
                conexion.Open();
               
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderUsuario(reader));
            
                reader.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("ERROR: DalUsuario SelectAll\n"+ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }

        public static Usuario Login(String email, String pass)
        {
            //Conexion cn = Conexion.Instance();
            String query = "SELECT * FROM usuario WHERE Email = @email AND Pass = @pass";
            List<Usuario> list = new List<Usuario>();

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@pass", pass);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderUsuario(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario SelectAll\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return list.Count > 0 ? list[0] : null;
            /*
            if (list.Count > 0)
            {
                // Retorna el usuario autenticado
                return list[0];
            }
            else
            {
                // No se encontró ningún usuario que coincida con las credenciales, retorna null o lanza una excepción
                return null;
            }
            */
        }

    }
}
