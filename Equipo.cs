using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class Equipo : IClub    //Los setter de las propiedades que pongas como private no se pueden asignar 
                            //dentro del objeto
    {
        private string _nombre;//De esta manera creo una propiedad privada que no se pueda modificar luego
                                //de creada
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (_nombre == null)
                {
                    _nombre = value;
                }
            }
        }

        public string Estadio { get; set; }

        public string DirectorTecnico { get; set; }

        public string Capitan { get; set; }

        public int AnoNacimiento { get; set; }

        public char Division { get; set; }

        public List<string> Refer { get; set; }
   

        public Equipo()
        {

        }

        public int Antiguedad(int anoActual)
        {
            return 0;
        }
    }
}




