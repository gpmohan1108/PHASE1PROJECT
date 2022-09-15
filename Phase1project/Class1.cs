using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1project
{
    class OneDayTeam : Player, ITeam
    {
        public static List <Player> ODIlist = new List <Player> ();
        public OneDayTeam()
        {
            ODIlist.Capacity = 11;
        }
        public void Add(Player player)
        {
            ODIlist.Add(player);
        }
        public void Remove(int playerId)
        {
            Player p = null;

            foreach (var i in ODIlist)
            {
                if (i.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", i.PlayerId);
                    p = i;
                }
            }

            ODIlist.Remove(p);
        }
        public Player GetPlayerById(int playerId)
        {
            Player p = null;

            foreach (var i in ODIlist)
            {
                if (i.PlayerId == playerId)
                {
                    p = i;
                    break;
                }
                else
                {
                    Console.WriteLine("Player ID not found.");
                }
            }
            return p;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player p = null;

            foreach (var i in ODIlist)
            {
                if (i.PlayerName == playerName)
                {
                    p = i;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name not found.");
                }
            }
            return p;
        }

        public List <Player> GetAllPlayers()
        {
            return ODIlist;
        }
    }
}