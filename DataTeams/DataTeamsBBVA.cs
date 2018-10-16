using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class DataTeamsBBVA
    {


        Equipos RealMadrid = new Equipos();
        

        public DataTeamsBBVA()
        {

            RealMadrid.Nombre = "Real Madrid Club de Futbol";
            RealMadrid.Division = 'A';
            RealMadrid.DirectorTecnico = "Julen Lopetegui";
            RealMadrid.Capitan = "Sergio Ramos";
            RealMadrid.Estadio = "Santiago Bernabéu";
            RealMadrid.AnoNacimiento = 1902;
            RealMadrid.Refer = new List<string>() { "Marcelo", "T. Kroos", "G. Bale" };

        }

        public List<Equipos> FetchBBVATeams()
        {
            List<Equipos> equipos = new List<Equipos>
            {
                RealMadrid,
            };


            return equipos;
        }



    }


}
