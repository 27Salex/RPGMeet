using BackRPG.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPGMeet.DAL
{

    /*
    - CREAR PARA VER TODOS LOS USUARIOS  --- SelectAll()
    - CREAR PARA LOGIN  --- Login(User, Pass)
    - CREAR PARA INSERTAR UN USUARIO --- Insert(User)
    - CREAR PARA MODIFICAR DATOS DE USUARIO CUANDO SU ID SEA ?? --- Update(User)

    - CREAR PARA MODIFICAR EL PASSWORD CUANDO SU ID SEA ?? Y EL PASSQORD SEA EL ANTIGUO 
    - CREAR PARA ELIMINAR UN USUARIO CUANDO LA ID SEA ?? 
    
    - CREAR PARA VER TODAS LAS PARTIDASQUE HA CREADO UN USUARIO CUANDO LA ID SEA ?? 
    - CREAR PARA VER TODAS LAS HISTORIAS DE UN USUARIO CUANDO LA ID SEA ?? 
     */
    public static class DalUsuario
    {
        private static SqlConnection conexion = Conexion.Instance().Connection;

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


        public static List<Usuario> SelectAll()
        {
            String selectQuery = "SELECT * FROM usuario";
            List<Usuario> list = new List<Usuario>();

            //SqlConnection conexion = new SqlConnection(cadenaConexion);

            try 
            {
                conexion.Open();
               
                SqlCommand command = new SqlCommand(selectQuery, conexion);
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
            String selectQuery = "SELECT * FROM usuario WHERE Email = @email AND Pass = @pass";
            List<Usuario> list = new List<Usuario>();

           // SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@pass", pass);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderUsuario(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario Login\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list.Count > 0 ? list[0] : null;
        }




        public static Usuario Register(Usuario user)
        {
            String insertQuery = "INSERT INTO Usuario (Email, Pass, Username, FKLocalidad ) VALUES (@email, @pass, @username, @FKLocalidad);";
            String selectQuery = "SELECT * FROM Usuario WHERE Email = @email";
            Usuario insertado = null;
            try
            {
                conexion.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, conexion);
                insertCommand.Parameters.AddWithValue("@email", user.Email);
                insertCommand.Parameters.AddWithValue("@pass", user.Pass);
                insertCommand.Parameters.AddWithValue("@username", user.Username);
                insertCommand.Parameters.AddWithValue("@FKLocalidad", user.FKLocalidad);


                int rowsAffected = insertCommand.ExecuteNonQuery();


                if (rowsAffected > 0) // AFECTAR A UNA COLUMNA ES LO MISMO QUE NSERTAR 
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, conexion);
                    selectCommand.Parameters.AddWithValue("@email", user.Email);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    insertado = ReaderUsuario(reader);
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario Register\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return insertado;

        }

        // hay que ver como sera el formulario de modificar informacion 
        public static Usuario Update(Usuario user)
        {
            String updateQuery = "UPDATE Usuario SET  Pass = @pass, Username = @username, FKLocalidad = @FKLocalidad WHERE IdUsuario = @id";

            String selectQuery = "SELECT * FROM Usuario WHERE IdUsuario = @id";
            Usuario insertado = null;
            try
            {
                conexion.Open();

                SqlCommand insertCommand = new SqlCommand(updateQuery, conexion);
                insertCommand.Parameters.AddWithValue("@id", user.IdUsuario);
                insertCommand.Parameters.AddWithValue("@pass", user.Pass);
                insertCommand.Parameters.AddWithValue("@username", user.Username);
                insertCommand.Parameters.AddWithValue("@FKLocalidad", user.FKLocalidad);


                int rowsAffected = insertCommand.ExecuteNonQuery();


                if (rowsAffected > 0) // AFECTAR A UNA COLUMNA ES LO MISMO QUE NSERTAR 
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, conexion);
                    selectCommand.Parameters.AddWithValue("@id", user.IdUsuario);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    insertado = ReaderUsuario(reader);
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario Update\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return insertado;

        }

        public static Usuario SelectById(int idUsuario)
        {
            String selectQuery = "SELECT * FROM usuario WHERE IdUsuario = @id";
            Usuario usuarioBuscado = null;

            try
            {
                conexion.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@id", idUsuario);
                SqlDataReader reader = selectCommand.ExecuteReader();

                usuarioBuscado = ReaderUsuario(reader);

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
            return usuarioBuscado;
        }


        public static Usuario CheckUsername(String username)
        {
            String selectQuery = "SELECT * FROM usuario WHERE Username = @username";
            List<Usuario> list = new List<Usuario>();

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderUsuario(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario Login\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list.Count > 0 ? list[0] : null;
        }
    }


    
}
