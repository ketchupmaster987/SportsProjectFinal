using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Team
    {

        public string Name { get; set; }

        public List<IPlayer> teamPlayers;

        public Team()
        {
            teamPlayers = new List<IPlayer>();
            Name = "default team name";
        }

        public void AddPlayer(IPlayer player)
        { 
            teamPlayers.Add(player);
        }

        public void RemovePlayer(IPlayer player)
        {
            teamPlayers.Remove(player);
        }

        public bool ContainsPlayer(IPlayer player)
        {
            if (teamPlayers.Contains(player))
            {
                return true;
            }

            return false;
        }
    }
}
