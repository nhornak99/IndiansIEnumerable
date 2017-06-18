using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorPractice2
{
    class Program
    {   
        static void Main(string[] args)
        {
            Player lonnie = new Player { Name = "Lonnie Chisenhall", Position = "RF" };
            Player jose = new Player { Name = "Jose Ramirez", Position = "3B" };

            Team indians = new Team();

            indians.playerArray = new Player[26];
            indians.playerList = new List<Player>(new Player[26]);

            indians.playerArray[0] = new Player { Name = "Fransisco Lindor", Position = "SS" };
            indians.playerList[0] = new Player { Name = "Andrew Miller", Position = "P" };

            indians.AddPlayerToArray(lonnie);
            indians.AddPlayerToList(jose);

            indians.JoinArrayPlayers(indians.playerArray, indians.playerList);

            foreach (Player p in indians)
            {
                Console.WriteLine(p.Name + " ..... " + p.Position);

            }

            Console.ReadLine();
        }
    }
}

