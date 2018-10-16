using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    public class Equipos : IClub
    {
        public string Nombre { get; set; }
        public string Estadio { get; set; }
        public string DirectorTecnico { get; set; }
        public string Capitan { get; set; }
        public int AnoNacimiento { get; set; }
        public char Division { get; set; }
        public List<string> Refer { get; set; }
        public void AñosDelClub()
        {

        }
        public Equipos()    
        {
                
        }

        
    }
}




