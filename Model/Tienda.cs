using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string Direccion { get; set; }
        public TimeSpan? HoraApertura { get; set; }
        public TimeSpan? HoraCierre { get; set; }
        public int CodigoPostal { get; set; }
        public int? FKLocalidad { get; set; }



        public Tienda() { }

        public Tienda(int idTienda)
        {
            IdTienda = idTienda;
        }

        public Tienda(int idTienda, string nombreTienda, string direccion, int codigoPostal)
        {
            IdTienda = idTienda;
            NombreTienda = nombreTienda;
            Direccion = direccion;
            CodigoPostal = codigoPostal;
        }

        public override string ToString()
        {
            return "Tienda: id: " + IdTienda + " NombreTienda: " + NombreTienda + " Direccion: " + Direccion + " HoraApertura: " + HoraApertura + " HoraCierre: " + HoraCierre + "CodigoPostal: " + CodigoPostal + "FKLocalidad: " + FKLocalidad;
        }
    }

}