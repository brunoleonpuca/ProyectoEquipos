namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;

    class Menu
    {
        Ligas leagues;
        List<Equipos> team;
        Ligas ligas = new Ligas();
        int teamDecision = 0;
        Utils utils = new Utils();
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
            List<Ligas> league = ligas.AddTeams();
            int leagueCounter = 1;
            foreach (var leagues in league)
            {
                Console.WriteLine(leagueCounter + " - " + leagues.Nombre);
                Console.WriteLine(leagues.TeamsQuantity + " equipos disponibles\n");
                leagueCounter++;
            }
            leagues = utils.DataLeagueVerification(league, leagues, team);
            team = leagues.FetchTeams;

        }

        public void MostrarMenu()
        {
            int teamCounter = 1;
            Console.Clear();
            Console.WriteLine(leagues.Nombre + " seleccionada");
            Console.WriteLine(leagues.TeamsQuantity + " equipos almacenados\n");
            foreach (var teams in team)
            {
                Console.WriteLine(teamCounter + " - " + teams.Nombre);
                teamCounter++;
            }
        }

        public void TeamSelection()
        {
            int teamDecision = utils.DataTeamVerification(team);
        }

        public void ShowTeam()
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

            Console.WriteLine("\nPresione Enter cuando desee continuar");
            Console.ReadKey();
        }

        public int Continue()
        {
            int userSelection = 0;

            userSelection = utils.DataMenuVerification();
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    break;
                case 2:
                    userSelection = 2;
                    break;
                case 3:
                    userSelection = 0;
                    Console.WriteLine("------------FIN DEL PROGRAMA------------\nEnter para Finalizar...");
                    Console.ReadKey();
                    break;
            }
            return userSelection;
        }
        


    }
}

