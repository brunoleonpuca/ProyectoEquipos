namespace Equipos_de_Futbol
{
    using System.Collections.Generic;

    interface IClub
    {

        string Nombre { get; set; }
        string Estadio { get; set; }
        string DirectorTecnico { get; set; }
        string Capitan { get; set; }
        int AnoNacimiento { get; set; }
        char Division { get; set; }
        List<string> Refer { get; set; }



    }
}
