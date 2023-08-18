using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RPGMeet.DAL
{
    public class DalLocalidad
    {
        public static SqlConnection connection = Conexion.Instance().Connection;

        public static Localidad ReaderLocalidad(SqlDataReader reader)
        {
            Localidad localidad = new Localidad();

            localidad.IdLocalidad = (int)reader["IdLocalidad"];
            localidad.NombreLocalidad = reader["NombreLocalidad"].ToString();

            return localidad;
        }

        public static List<Localidad> SelectAll()
        {
            string selectQuery = "SELECT * FROM Localidad";
            List<Localidad> list = new List<Localidad>();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ReaderLocalidad(reader));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: DalLocalidad SelectAll\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }
    }
}