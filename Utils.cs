namespace Equipos_de_Futbol
{
    using System;
    using System.Collections.Generic;

    class Utils
    {        

        public Utils()
        {
            
        }
        public Ligas DataLeagueVerification(List<Ligas> league, Ligas leagues, List<Equipos> team)
        {
            int userDecision = 0;
            bool status = false;
            while (!status)
            {
                Console.WriteLine("Elija Liga ingresando valor y confirme presionando Enter");
                status = int.TryParse(Console.ReadLine(), out userDecision);
                if (status)
                {
                    if (userDecision > league.Count || userDecision < 0)
                    {
                        Console.WriteLine("Dato ingresado no valido");
                        userDecision = 0;
                        status = false;
                    }
                    else
                    {
                        leagues = league[userDecision - 1];
                    }
                }
                else
                {
                    Console.WriteLine("Dato ingresado no valido");
                    userDecision = 0;
                }
            }
            return leagues;
        }

        public int DataTeamVerification(List<Equipos> team)
        {
            int userDecision = 0;
            bool status = false;
            while (!status)
            {
                Console.WriteLine("Elija Equipo ingresando valor y confirme presionando Enter");
                status = int.TryParse(Console.ReadLine(), out userDecision);
                if (status)
                {
                    if (userDecision > team.Count || userDecision < 0)
                    {
                        Console.WriteLine("Dato ingresado no valido");
                        userDecision = 0;
                        status = false;
                    }
                }
                else
                {
                    Console.WriteLine("Dato ingresado no valido");
                    userDecision = 0;
                }
            }
            return userDecision;
        }
    }
}
