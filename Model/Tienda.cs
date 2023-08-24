﻿using System;
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
        public int IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string Direccion { get; set; }
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

        public Tienda(int idTienda, string nombreTienda, string direccion, int codigoPostal)
        {
            IdTienda = idTienda;
            NombreTienda = nombreTienda;
            Direccion = direccion;
            CodigoPostal = codigoPostal;
        }

        public override string ToString()
        {
            return "Tienda: id: " + IdTienda + " NombreTienda: " + NombreTienda + " Direccion: " + Direccion + "CodigoPostal: " + CodigoPostal;
        }
    }

}