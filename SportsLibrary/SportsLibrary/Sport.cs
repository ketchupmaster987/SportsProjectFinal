using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Sport
    {
        string Name { get; }
        string Description { get; }

        List<Team> Teams { get; }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }

        public bool ContainsTeam(Team team)
        {
            return Teams.Contains(team);
        }
    }
}
