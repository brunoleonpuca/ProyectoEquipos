namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;
    
    class DataTeamsBBVA
    {


        Equipos RealMadrid = new Equipos();
        Equipos Barcelona = new Equipos();
        Equipos Sevilla = new Equipos();

        public DataTeamsBBVA()
        {
            RealMadrid.Nombre = "Real Madrid Club de Futbol";
            RealMadrid.Division = 'A';
            RealMadrid.DirectorTecnico = "Julen Lopetegui";
            RealMadrid.Capitan = "Sergio Ramos";
            RealMadrid.Estadio = "Santiago Bernabéu";
            RealMadrid.AnoNacimiento = 1902;
            RealMadrid.Refer = new List<string>() { "Marcelo", "T. Kroos", "G. Bale" };

            Barcelona.Nombre = "Futbol Club Barcelona";
            Barcelona.Division = 'A';
            Barcelona.DirectorTecnico = "Ernesto Valverde";
            Barcelona.Capitan = "Lionel Messi";
            Barcelona.Estadio = "Camp Nou";
            Barcelona.AnoNacimiento = 1899;
            Barcelona.Refer = new List<string>() { "Luis Suarez", "G. Pique", "Coutinho" };

            Sevilla.Nombre = "Sevilla Futbol Club";
            Sevilla.Division = 'A';
            Sevilla.DirectorTecnico = "Pablo Machin";
            Sevilla.Capitan = "Jesus Navas";
            Sevilla.Estadio = "Ramón Sánchez Pizjuán";
            Sevilla.AnoNacimiento = 1899;
            Sevilla.Refer = new List<string>() { "Simon Kjær", "Nolito", "E. Banega" };







        } //BASE DE DATOS DE EQUIPOS - BBVA

        public List<Equipos> FetchTeams()
        {
            List<Equipos> equipos = new List<Equipos>
            {
                RealMadrid,
                Barcelona,
                Sevilla,
            };


            return equipos;
        }



    }


}
