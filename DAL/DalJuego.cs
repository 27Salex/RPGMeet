using RPGMeet.Model;
using RPGMeet.Models;
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

        public static Juego SelectById(int idJuego)
        {
            String selectQuery = "SELECT * FROM Juego WHERE IdJuego = @id";
            Juego JuegoBuscado = null;

            try
            {
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@id", idJuego);
                SqlDataReader reader = selectCommand.ExecuteReader();

                reader.Read();

                JuegoBuscado = ReaderJuego(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalJuego SelectById\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return JuegoBuscado;
        }

        public static int GetIdByName(string nombreJuego)
        {
            String selectQuery = "SELECT * FROM Juego WHERE NombreJuego = @nombreJuego";
            Juego juegoBuscado = null;

            try
            {
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@nombreJuego", nombreJuego);
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                reader.Read();
                juegoBuscado = ReaderJuego(reader);

                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: DalJuego GetIdByName\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return juegoBuscado.IdJuego;
        }
    }
}