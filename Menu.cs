using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_Futbol
{
    class Menu
    {
        List<Equipos> team;
        Ligas ligas = new Ligas();
        //1)Un foreach que recorra el listado de objetos e imprima los titulos de los equipos
        //2)Usuario ingresa valor de acorde al lenght de ese listado
        //3)Verificar valor de dato ingresado, si True mostrar propiedades, si False: Advertencia
        //La idea es mostrar el titulo de los equipos que esten cargados en ese momento
        //En un futuro que tenga ligas y dentro los equipos
        //Se permite seleccionar la liga/equipos con el numero que se ingresa, verificandolo
        //En caso de la liga se abre el listado de equipos, en caso del equipo sus estadisticas 
        public Menu()
        {
            Console.WriteLine("---------BASE DE DATOS DE EQUIPOS----------");
            Console.WriteLine("\nELIJA LIGA PARA MOSTRAR DATOS");

        }

        public void LeagueSelection()
        {

            var league = ligas.AddTeams();
            int leagueDecision = 0;
            int leagueCounter = 1;
            foreach (var leagues in league)
            {
                Console.WriteLine(leagueCounter + " - " + leagues.Nombre);
                Console.WriteLine(leagues.TeamsQuantity + " equipos disponibles\n");
                leagueCounter++;
            }
            while (leagueDecision == 0)
            {
                //Regex r = new Regex("^[a-zA-Z]*$"); Libreria para validar datos
                //Habria que llamar a 'r' y con un If validar los datos 
                Console.WriteLine("Elija Liga ingresando valor y confirme presionando Enter");
                leagueDecision = Convert.ToInt32(Console.ReadLine());
                if (leagueDecision > league.Count || leagueDecision < 0)
                {
                    Console.WriteLine("Dato ingresado no valido");
                    leagueDecision = 0;
                }
                else
                {
                    switch (leagueDecision)
                    {
                        case 1: //AFA SELECTION
                            var leagues = league[leagueDecision];
                            team = new DataTeamsAFA().FetchAFATeams();
                            break;
                        case 2: //BBVA SELECTION
                            leagues = league[leagueDecision];
                            team = new DataTeamsBBVA().FetchBBVATeams();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void MostrarMenu()
        {
            int teamCounter = 1;
            foreach (var teams in team)
            {
                Console.WriteLine(teamCounter + " - " + teams.Nombre);
                teamCounter++;
            }
        }


        public int VerifyValue()
        {
            int teamDecision = 0;
            while (teamDecision == 0)
            {
                Console.WriteLine("Elija equipo ingresando valor y confirme presionando Enter");
                teamDecision = Convert.ToInt32(Console.ReadLine());
                if (teamDecision > team.Count || teamDecision < 0)
                {
                    Console.WriteLine("Dato ingresado no valido");
                    teamDecision = 0;
                }
            }
            return teamDecision - 1;
        }

        public void ShowTeam(int teamDecision)
        {
            for (int i = 0; i < team.Count; i++)
            {
                Console.WriteLine("Nombre: " + team[teamDecision].Nombre);
                Console.WriteLine("Estadio: " + team[teamDecision].Estadio);
                Console.WriteLine("Director Tecnico: " + team[teamDecision].DirectorTecnico);
                Console.WriteLine("Capitan: " + team[teamDecision].Capitan);
                Console.WriteLine("Año de Fundacion: " + team[teamDecision].AnoNacimiento);
                Console.WriteLine("Division Actual: " + team[teamDecision].Division);
                int referPlayers = 1;
                for (int z = 0; z < team[teamDecision].Refer.Count; z++)
                {
                    Console.WriteLine("Referente: " + referPlayers + " :" + team[teamDecision].Refer[z]);
                    referPlayers++;
                }

                Console.ReadKey();

            }
        }




    }
}

