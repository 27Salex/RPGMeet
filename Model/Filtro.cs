using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Filtro
    {
        List<string>listJuegos = new List<string>();
        public List<string> ListJuegos { get => listJuegos; set => listJuegos = value; }
        List<string> listTematicas = new List<string>();
        public List<string> ListTematicas { get => listTematicas; set => listTematicas = value; }

        public bool QuedarLunes { get; set; }
        public bool QuedarMartes { get; set; }
        public bool QuedarMiercoles { get; set; }
        public bool QuedarJueves { get; set; }
        public bool QuedarViernes { get; set; }
        public bool QuedarSabado { get; set; }
        public bool QuedarDomingo { get; set; }
       
        public bool QuedarCualquierDia {
            get
            {
                return (!QuedarLunes && !QuedarMartes && !QuedarMiercoles && !QuedarJueves
                         && !QuedarViernes && !QuedarSabado && !QuedarDomingo) ||
                        (QuedarLunes && QuedarMartes && QuedarMiercoles && 
                        QuedarJueves && QuedarViernes && QuedarSabado && QuedarDomingo);
            }
        }
            
        public short MaxJugadores { get; set; }
        

        public Filtro(bool quedarLunes = false, bool quedarMartes = false,
            bool quedarMiercoles = false, bool quedarJueves = false, bool quedarViernes = false, 
            bool quedarSabado = false, bool quedarDomingo = false,
             short maxJugadores = 10)
        {
            QuedarLunes = quedarLunes;
            QuedarMartes = quedarMartes;
            QuedarMiercoles = quedarMiercoles;
            QuedarJueves = quedarJueves;
            QuedarViernes = quedarViernes;
            QuedarSabado = quedarSabado;
            QuedarDomingo = quedarDomingo;
            MaxJugadores= maxJugadores;
        }
        public override string ToString()
        {
            string tematicas = string.Join(", ", ListTematicas);
            string dias = $"Lunes: {QuedarLunes}, Martes: {QuedarMartes}, Miércoles: {QuedarMiercoles}, Jueves: {QuedarJueves}, Viernes: {QuedarViernes}, Sábado: {QuedarSabado}, Domingo: {QuedarDomingo}";

            return $"Temáticas: {tematicas}\nDías: {dias} \nNumJugadores: {MaxJugadores}";
        }
    }
}