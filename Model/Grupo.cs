using System;

namespace RPGMeet.Models
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string TituloParitda { get; set; }
        public short EstadoGrupo { get; set; } // FINALIZADA -1  BUSCANDO 0 START 1
        public short MaxJugadores { get; set; }
        public int FKGameMaster { get; set; }
        public int FKCampaing { get; set; }
        public bool EsOnline { get; set; } ;
        public bool QuedarLunes { get; set; } ;
        public bool QuedarMartes { get; set; };
        public bool QuedarMiercoles { get; set; } ;
        public bool QuedarJueves { get; set; } ;
        public bool QuedarViernes { get; set; } ;
        public bool QuedarSabado { get; set; } ;
        public bool QuedarDomingo { get; set; } ;

        public Grupo() { }

        public Grupo(int IdGrupo)
        {
            IdGrupo = IdGrupo;
        }

        public


    }
}
