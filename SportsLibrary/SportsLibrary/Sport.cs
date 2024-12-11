using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Sport
    {
        

        public string Name { get; set; }
        public string Description { get; set; }

        List<Team> Teams { get; }

        public Sport()
        {
            Teams = new List<Team>();
            Name = "default sport name";
            Description = "this is a sport";
        }

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
