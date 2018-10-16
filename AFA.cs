using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class AFA : Equipo
    {

        List<Equipo> addTeams = new List<Equipo>();


        public AFA()
        {
            Equipo RiverPlate = new Equipo();
            RiverPlate.Nombre = "Club Atletico River Plate";
            RiverPlate.Division = 'A';
            RiverPlate.DirectorTecnico = "Marcelo Gallardo";
            RiverPlate.Capitan = "Leonardo Ponzio";
            RiverPlate.Estadio = "Antonio Vespucio Liberti";
            RiverPlate.AnoNacimiento = 1901;
            RiverPlate.Refer = new List<string>() { "J. Maidana", "F. Armani", "Pity Martinez" };
            addTeams.Add(RiverPlate);

            Equipo BocaJuniors = new Equipo();
            BocaJuniors.Nombre = "Boca Juniors";
            BocaJuniors.Division = 'A';
            BocaJuniors.DirectorTecnico = "Guillermo Barros Schelotto";
            BocaJuniors.Capitan = "Pablo Perez";
            BocaJuniors.Estadio = "Alberto J. Armando";
            BocaJuniors.AnoNacimiento = 1905;
            BocaJuniors.Refer = new List<string>() { "F. Gago", "D. Benedeto", "M. Zarate" };
            addTeams.Add(BocaJuniors);

        }

    }

}
