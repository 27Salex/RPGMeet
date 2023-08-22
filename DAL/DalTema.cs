using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RPGMeet.DAL
{
    public class DalTema
    {
        public static SqlConnection connection = Conexion.Instance().Connection;

        public static Tema ReaderTema(SqlDataReader reader)
        {
            Tema tema = new Tema();

            tema.IdTema = (int)reader["IdTema"];
            tema.NombreTema = reader["NombreTema"].ToString();

            return tema;
        }

        public static List<Tema> SelectAll()
        {
            string selectQuery = "SELECT * FROM Tema";
            List<Tema> list = new List<Tema>();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ReaderTema(reader));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: DalTema SelectAll\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }
    }
}