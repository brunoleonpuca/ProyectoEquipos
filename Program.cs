namespace Equipos_de_Futbol
{

    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            Menu menu = new Menu();
            while (loop != 0)
            {
                if(loop == 1)
                {
                    menu.LeagueSelection();
                }
                loop = 2;
                if(loop == 2)
                {
                    menu.MostrarMenu();
                    menu.TeamSelection();
                    menu.ShowTeam();
                } 
                loop = menu.Continue();
            }
           


        }
    }
}
