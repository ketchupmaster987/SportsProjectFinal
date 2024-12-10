using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Player : Person, IPlayer
    {
        public int Number { get; protected set; }
    }
}
