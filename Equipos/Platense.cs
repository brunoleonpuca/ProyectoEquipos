using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    class Platense : Equipo, IClub
    {
       
        public int Antiguedad(int AnoActual)
        {
            return AnoNacimiento - AnoActual;
        }

        public void VenderJugador()
        {

        }


    }
}
