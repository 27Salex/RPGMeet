using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPGMeet.DAL
{

    // !! REVISAR EN FUNCION DEL MODELO 
    public static class DalTienda
    {
        private static SqlConnection conexion = Conexion.Instance().Connection;

      /// <summary>
      /// Devuelve todas las tiendas de la base de datos 
      /// </summary>
      /// <param name="reader"></param>
      /// <returns></returns>
        public static Tienda ReaderTienda(SqlDataReader reader)
        {
            Tienda tienda = new Tienda();

            tienda.IdTienda = (int)reader["IdTienda"];
            tienda.NombreTienda = reader["NombreTienda"].ToString();
            tienda.Direccion = reader["Direccion"].ToString();
            tienda.Descripcion = reader["Descripcion"].ToString();
            tienda.CodigoPostal = (int)reader["CodigoPostal"];
            tienda.Web = reader["Web"].ToString();
            tienda.Telefono = (int)reader["Telefono"];
            tienda.ImgUrl = reader["UrlImg"].ToString();

            /*
            tienda.HoraApertura = !reader.IsDBNull(reader.GetOrdinal("HoraApertura")) ? (TimeSpan)reader["HoraApertura"] : null;
            tienda.HoraCierre = !reader.IsDBNull(reader.GetOrdinal("HoraCierre")) ? (TimeSpan)reader["HoraCierre"] : null;
            tienda.FKLocalidad = !reader.IsDBNull(reader.GetOrdinal("FKLocalidad")) ? (int)reader["FKLocalidad"] : null;
*/
            return tienda;
        }


        public static List<Tienda> SelectAll()
        {
            String selectQuery = "SELECT * FROM Tienda";
            List<Tienda> list = new List<Tienda>();      

            try 
            {
                conexion.Open();
               
                SqlCommand command = new SqlCommand(selectQuery, conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderTienda(reader));
            
                reader.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("ERROR: DalTienda SelectAll\n"+ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }

      

        /// <summary>
        /// Devuelve la informacion de una sola tienda 
        /// </summary>
        /// <param name="idTienda"></param>
        /// <returns></returns>
    
        public static Tienda SelectById(int idTienda)
        {
            String selectQuery = "SELECT * FROM Tienda WHERE IdTienda = @id";
            Tienda TiendaBuscado = null;

            try
            {
                conexion.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@id", idTienda);
                SqlDataReader reader = selectCommand.ExecuteReader();

                TiendaBuscado = ReaderTienda(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalTienda SelectAll\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return TiendaBuscado;
        }

    }


    
}
