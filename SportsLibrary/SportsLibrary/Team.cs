using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Team
    {

        string Name { get; set; }

        public List<Player> teamPlayers;

        public Team()
        {
            teamPlayers = new List<Player>();
            Name = "default team name";
        }

        public void AddPlayer(Player player)
        { 
            teamPlayers.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            teamPlayers.Remove(player);
        }

        public bool ContainsPlayer(Player player)
        {
            if (teamPlayers.Contains(player))
            {
                return true;
            }

            return false;
        }
    }
}
