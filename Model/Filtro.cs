using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Filtro
    {
        private bool quedarCualquierDia = true;
        private bool quedarLunes=false;
        private bool quedarMartes=false;
        private bool quedarMiercoles=false;
        private bool quedarJueves=false;
        private bool quedarViernes=false;
        private bool quedarSabado=false;
        private bool quedarDomingo=false;
        private int minJugadores=0;
        private int maxJugadores=0;



        public Filtro(bool quedarLunes, bool quedarMartes,
            bool quedarMiercoles, bool quedarJueves, bool quedarViernes, 
            bool quedarSabado, bool quedarDomingo, bool quedarCualquierDia,
            int minJugadores, int maxJugadores)
        {
            this.quedarLunes = quedarLunes;
            this.quedarMartes = quedarMartes;
            this.quedarMiercoles = quedarMiercoles;
            this.quedarJueves = quedarJueves;
            this.quedarViernes = quedarViernes;
            this.quedarSabado = quedarSabado;
            this.quedarDomingo = quedarDomingo;
            this.quedarCualquierDia = quedarCualquierDia;
            this.minJugadores = minJugadores;
            this.maxJugadores= maxJugadores;
        }

        public bool QuedarLunes { get => quedarLunes; set => quedarLunes = value; }
        public bool QuedarMartes { get => quedarMartes; set => quedarMartes = value; }
        public bool QuedarMiercoles { get => quedarMiercoles; set => quedarMiercoles = value; }
        public bool QuedarJueves { get => quedarJueves; set => quedarJueves = value; }
        public bool QuedarViernes { get => quedarViernes; set => quedarViernes = value; }
        public bool QuedarSabado { get => quedarSabado; set => quedarSabado = value; }
        public bool QuedarDomingo { get => quedarDomingo; set => quedarDomingo = value; }
        public bool QuedarCualquierDia { get => quedarCualquierDia; set => quedarCualquierDia = value; }
        public int MinJugadores { get => minJugadores; set => minJugadores = value; }
        public int MaxJugadores { get => maxJugadores; set => maxJugadores = value; }
    }
}