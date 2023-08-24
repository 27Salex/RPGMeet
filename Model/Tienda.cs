using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{

    /*
     CREATE TABLE Tienda (
    IdTienda INT IDENTITY(1,1) PRIMARY KEY,
    NombreTienda VARCHAR(50) NOT NULL,
    Direccion VARCHAR(50) NOT NULL,
    HoraApertura TIME,
    HoraCierre TIME,
    CodigoPostal INT NOT NULL,
    FKLocalidad INT,
);
     */
    public class Tienda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodigoPostal { get; set; }
        public string Web { get; set; }
        public int Telefono { get; set; }
        public string ImgUrl { get; set; }



        public Tienda() { }

        public Tienda(int idTienda)
        {
            IdTienda = idTienda;
        }

        public Tienda(int id, string nombre, string descripcion, string urlImagen = "", string direccion = "", string sitioWeb = "", string telefono = "123 45 67 89", string codigoPostal = null)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            UrlImagen = urlImagen;
            Direccion = direccion;
            SitioWeb = sitioWeb;
            Telefono = telefono;
            CodigoPostal = codigoPostal;
        }
        public override string ToString()
        {
            return "Tienda: id: " + IdTienda + " NombreTienda: " + NombreTienda + " Direccion: " + Direccion + "CodigoPostal: " + CodigoPostal;
        }
    }

}