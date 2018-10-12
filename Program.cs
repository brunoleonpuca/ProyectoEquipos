using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo RiverPlate = new Equipo();
            RiverPlate.Nombre = "Club Atletico River Plate";
            RiverPlate.Division = 'A';
            RiverPlate.DirectorTecnico = "Marcelo Gallardo";
            RiverPlate.Capitan = "Leonardo Ponzio";
            RiverPlate.Estadio = "Antonio Vespucio Liberti";
            RiverPlate.AnoNacimiento = 1901;
            RiverPlate.Refer = new List<string>() {"J. Maidana","F. Armani","Pity Martinez" };
            
            Equipo BocaJuniors = new Equipo();
            BocaJuniors.Nombre = "Boca Juniors";
            BocaJuniors.Division = 'A';
            BocaJuniors.DirectorTecnico = "Guillermo Barros Schelotto";
            BocaJuniors.Capitan = "Pablo Perez";
            BocaJuniors.Estadio = "Alberto J. Armando";
            BocaJuniors.AnoNacimiento = 1905;
            BocaJuniors.Refer = new List<string>() { "F. Gago", "D. Benedeto", "M. Zarate" };


            var a = 1;
            List<Equipo> participantes = new List<Equipo>() { RiverPlate, BocaJuniors};
            int c = 1;
            foreach (var participante in participantes)
            {
                Console.WriteLine(c+" - "+participante.Nombre);
                c += 1;
            }
            Console.ReadKey();
                







        }
    }
}
