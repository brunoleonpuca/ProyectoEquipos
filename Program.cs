namespace Equipos_de_Futbol
{

    class Program
    {
        static void Main(string[] args)
        {
            int Loop = 0;
            

            Menu menu = new Menu();
            menu.LeagueSelection();
            menu.MostrarMenu();
            menu.TeamSelection();
            menu.ShowTeam();
            Loop = menu.Continue();


        }
    }
}
