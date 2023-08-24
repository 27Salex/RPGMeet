using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Juego
    {
        public int IdJuego { get; set;}
        public string NombreJuego { get; set;}
        public string Reglas { get; set; }
        public short MinJugadores { get; set;}
        public short MaxJugadores { get; set; }

        public Juego() { }

        public Juego(int idJuego)
        {
            IdJuego = idJuego;
        }

        public Juego(int idJuego, string nombreJuego, string reglas, short minJugadores, short maxJugadores)
        {
            IdJuego = idJuego;
            NombreJuego = nombreJuego;
            Reglas = reglas;
            MinJugadores = minJugadores;
            MaxJugadores = maxJugadores;
        }
    }
}