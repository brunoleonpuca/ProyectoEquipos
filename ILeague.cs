using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    interface ILeague
    {
        string Nombre { get; set; }
        int TeamsQuantity { get; set; }
        
    }
}
