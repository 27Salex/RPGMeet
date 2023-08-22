using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RPGMeet.DAL
{
    public class DalJuego
    {
        public static SqlConnection connection = Conexion.Instance().Connection;

        public static Juego ReaderJuego(SqlDataReader reader)
        {
            Juego juego = new Juego();

            juego.IdJuego = (int)reader["IdJuego"];
            juego.NombreJuego = reader["NombreJuego"].ToString();
            juego.Reglas = reader["Reglas"].ToString();
            juego.MinJugadores = (short)reader["MinJugadores"];
            juego.MaxJugadores = (short)reader["MaxJugadores"];
            
            return juego;
        }

        public static List<Juego> SelectAll()
        {
            string selectQuery = "SELECT * FROM Juego";
            List<Juego> list = new List<Juego>();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ReaderJuego(reader));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: DalJuego SelectAll\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }
    }
}