using System;
using System.Collections.Generic;

namespace Equipos_de_Futbol
{
    class Program
    {
        static void Main(string[] args)
        {

            int loop = 0;
            while (loop == 0)
            {
                Menu menu = new Menu();
                menu.LeagueSelection();
                menu.MostrarMenu();
                int teamChoose = menu.VerifyValue();
                menu.ShowTeam(teamChoose);
                loop = menu.Continue();
            }
            Console.WriteLine("----------PROGRAMA FINALIZADO----------");
            Console.WriteLine("Enter para finalizar...");
            Console.ReadKey();
        }
    }
}
