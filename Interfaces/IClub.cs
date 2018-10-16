﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    interface IClub
    {

        string Nombre { get; set; }
        string Estadio { get; set; }
        string DirectorTecnico { get; set; }
        string Capitan { get; set; }
        int AnoNacimiento { get; set; }
        char Division { get; set; }
        List<string> Refer { get; set; }
        void AñosDelClub();



    }
}