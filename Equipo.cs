using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class Equipo //Los setter de las propiedades que pongas como private no se pueden asignar 
                  //dentro del objeto
    {
        public string Nombre { get; set; }

        public string Estadio { get; set; }

        public string DirectorTecnico { get; set; }

        public string Capitan { get; set; }

        public int AnoNacimiento { get; set; }

        public char Division { get; set; }

        public List<string> Refer { get; set; }

        public Equipo()    
        {
                
        }

        
    }
}




