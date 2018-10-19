namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    interface ILeague
    {
        string Nombre { get; set; }
        int TeamsQuantity { get; set; }
        List<Equipos> FetchTeams { get; set; }
    }
}
