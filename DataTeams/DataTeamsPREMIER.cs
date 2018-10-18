using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class DataTeamsPREMIER
    {
        
        Equipos ManchesterUnited = new Equipos();
        Equipos Chelsea = new Equipos();
        Equipos Tottenham = new Equipos();

        public DataTeamsPREMIER()
        {
            ManchesterUnited.Nombre = "Manchester United Football Club";
            ManchesterUnited.Division = 'A';
            ManchesterUnited.DirectorTecnico = "Jose Mourinho";
            ManchesterUnited.Capitan = "Antonio Valencia";
            ManchesterUnited.Estadio = "Old Trafford";
            ManchesterUnited.AnoNacimiento = 1878;
            ManchesterUnited.Refer = new List<string>() { "Paul Pogba", "R. Lukaku", "David De Gea" };



            Chelsea.Nombre = "Chelsea Football Club";
            Chelsea.Division = 'A';
            Chelsea.DirectorTecnico = "Maurizio Sarri";
            Chelsea.Capitan = "Gary Cahill";
            Chelsea.Estadio = "Stamford Bridge";
            Chelsea.AnoNacimiento = 1905;
            Chelsea.Refer = new List<string>() { "N'golo Kante", "M. Kovacic", "E. Hazard" };

            Tottenham.Nombre = "Tottenham Football Club";
            Tottenham.Division = 'A';
            Tottenham.DirectorTecnico = "Mauricio Pochettino";
            Tottenham.Capitan = "Hugo Lloris";
            Tottenham.Estadio = "Wembley";
            Tottenham.AnoNacimiento = 1882;
            Tottenham.Refer = new List<string>() { "Harry Kane", "Dele Alli", "J. Vertonghen" };


        } //BASE DE DATOS DE EQUIPOS - PREMIER

        public List<Equipos> FetchTeams()
        {
            List<Equipos> equipos = new List<Equipos>()
            {
                ManchesterUnited,
                Chelsea,
                Tottenham,
            };

            return equipos;
        }



    }


}
