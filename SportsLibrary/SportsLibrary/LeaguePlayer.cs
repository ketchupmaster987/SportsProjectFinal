using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class LeaguePlayer : IPlayer
    {
        public int Number { get; protected set; }
        string Position { get; }


    }
}
