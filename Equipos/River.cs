using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    class River : Equipo, IClub //Implementacion de la interfaz
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
