using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    class Ligas : ILeague
    {

        public string Nombre { get; set; }
        public int TeamsQuantity { get; set; }
        Ligas AFA = new Ligas();
        Ligas BBVA = new Ligas();

        public Ligas()
        {

            AFA.Nombre = "AFA";
            AFA.TeamsQuantity = new DataTeamsAFA().FetchAFATeams().Count;

            BBVA.Nombre = "BBVA";
            BBVA.TeamsQuantity = new DataTeamsBBVA().FetchBBVATeams().Count;

        }

        public List<Ligas> AddTeams()
        {
            List<Ligas> ligas = new List<Ligas>
            {
                AFA,
                BBVA,
            };

            return ligas;
        }


    }
}
