namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Utils
    {
        public int Selection { get; set; }
        public int Loop { get; set; }

        public Utils()
        {
            Menu menu = new Menu();
            menu.LeagueSelection();
            menu.MostrarMenu();
            int teamChoose = menu.VerifyValue();
            menu.ShowTeam(teamChoose);
            Loop = menu.Continue();

        }
    }

}
