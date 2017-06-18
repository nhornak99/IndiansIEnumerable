using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorPractice2
{
    class Team : IEnumerable
    {
        private IEnumerable<Player> Roster { get; set; }
        int arrayIndex = 1;
        int listIndex = 1;

        public Player[] playerArray { get; set; }
        public List<Player> playerList { get; set; }

        public void AddRoster(IEnumerable<Player> players)
        {
            Roster = players;
        }

        public void JoinArrayPlayers(Player[] _array, List<Player> _list)
        {
            Roster = _list.Concat(_array);
        }

        public void AddPlayerToArray(Player player)
        {
            playerArray[arrayIndex] = player;
            arrayIndex++;
        }

        public void AddPlayerToList(Player player)
        {
            playerList[listIndex] = player;
            listIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Roster:");
            foreach (Player p in Roster)
            {
                if (p != null)
                {
                    yield return p;
                }
                
            }
        }
    }
}
