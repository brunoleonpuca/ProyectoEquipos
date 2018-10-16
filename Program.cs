using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu menu = new Menu();
            int leagueSelection = menu.LeagueSelection();
            menu.MostrarMenu();
            int teamChoose = menu.VerifyValue();
            menu.ShowTeam(teamChoose);
        
            


        }

    }

}
