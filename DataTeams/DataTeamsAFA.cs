namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;
    
    class DataTeamsAFA
    {


        Equipos RiverPlate = new Equipos();
        Equipos BocaJuniors = new Equipos();
        Equipos Independiente = new Equipos();
        Equipos Racing = new Equipos();
        Equipos SanLorenzo = new Equipos();

        public DataTeamsAFA()
        {

            RiverPlate.Nombre = "Club Atletico River Plate";
            RiverPlate.Division = 'A';
            RiverPlate.DirectorTecnico = "Marcelo Gallardo";
            RiverPlate.Capitan = "Leonardo Ponzio";
            RiverPlate.Estadio = "El Monumental - Antonio Vespucio Liberti";
            RiverPlate.AnoNacimiento = 1901;
            RiverPlate.Refer = new List<string>() { "J. Maidana", "F. Armani", "Pity Martinez" };

            BocaJuniors.Nombre = "Club Atletico Boca Juniors";
            BocaJuniors.Division = 'A';
            BocaJuniors.DirectorTecnico = "Guillermo Barros Schelotto";
            BocaJuniors.Capitan = "Pablo Perez";
            BocaJuniors.Estadio = "La Bombonera - Alberto J. Armando";
            BocaJuniors.AnoNacimiento = 1905;
            BocaJuniors.Refer = new List<string>() { "F. Gago", "D. Benedeto", "M. Zarate" };

            Independiente.Nombre = "Club Atletico Independiente";
            Independiente.Division = 'A';
            Independiente.DirectorTecnico = "Ariel Holan";
            Independiente.Capitan = "Maximiliano Meza";
            Independiente.Estadio = "La Doble Viscera - Estadio Libertadores de America";
            Independiente.AnoNacimiento = 1905;
            Independiente.Refer = new List<string>() { "E. Gigliotti", "M. Benitez", "M. Campaña" };

            Racing.Nombre = "Racing Club";
            Racing.Division = 'A';
            Racing.DirectorTecnico = "Eduardo Coudet";
            Racing.Capitan = "Lisandro Lopez";
            Racing.Estadio = "Juan Domingo Peron - El Cilindro de Avellaneda";
            Racing.AnoNacimiento = 1903;
            Racing.Refer = new List<string>() { "R. Centurion", "L. Sigali", "J. Cristaldo" };

            SanLorenzo.Nombre = "Club Atlético San Lorenzo de Almagro";
            SanLorenzo.Division = 'A';
            SanLorenzo.DirectorTecnico = "Claudio Biaggio";
            SanLorenzo.Capitan = "Fabricio Coloccini";
            SanLorenzo.Estadio = "Pedro Bidegain - El Nuevo Gasometro";
            SanLorenzo.AnoNacimiento = 1908;
            SanLorenzo.Refer = new List<string>() { "N. Blandi", "F. Belluschi", "S. Torrico" };

        } //BASE DE DATOS DE EQUIPOS - AFA


        public List<Equipos> FetchTeams()
        {
            List<Equipos> equipos = new List<Equipos>
            {
                RiverPlate,
                BocaJuniors,
                Independiente,
                Racing,
                SanLorenzo,
            };


            return equipos;
        }



    }


}
