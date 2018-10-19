namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class Ligas : ILeague
    {

        public string Nombre { get; set; }
        public int TeamsQuantity { get; set; }
        public List<Equipos> FetchTeams { get; set; }

        public Ligas()
        {

        }

        public List<Ligas> AddTeams() //BASE DE DATOS DE LIGAS
        {
            Ligas AFA = new Ligas();
            Ligas BBVA = new Ligas();
            Ligas PREMIER = new Ligas();
            
            AFA.Nombre = "AFA - Superliga argentina";
            AFA.TeamsQuantity = new DataTeamsAFA().FetchTeams().Count;
            AFA.FetchTeams = new DataTeamsAFA().FetchTeams();

            BBVA.Nombre = "BBVA - Liga española";
            BBVA.TeamsQuantity = new DataTeamsBBVA().FetchTeams().Count;
            BBVA.FetchTeams = new DataTeamsBBVA().FetchTeams();


            PREMIER.Nombre = "Premier League - Liga inglesa";
            PREMIER.TeamsQuantity = new DataTeamsPREMIER().FetchTeams().Count;
            PREMIER.FetchTeams = new DataTeamsPREMIER().FetchTeams();
            
            List<Ligas> ligas = new List<Ligas>
            {
                AFA,
                BBVA,
                PREMIER,
            };

            return ligas;
        }


    }
}
