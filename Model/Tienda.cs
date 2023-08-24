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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public string Direccion { get; set; }
        public string SitioWeb { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }

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
            return $"ID: ${Id}, Nombre: ${Nombre}, Descripción: ${Descripcion}, Imagen: ${UrlImagen}, Dirección: ${Direccion}, Web: ${SitioWeb}, Teléfono: ${Telefono}";
        }
    }

}