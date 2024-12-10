using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        public int id { get; set; }

        protected static int count;

        public Person()
        {
            Name = "person name";
            count++;
            this.id = count;
        }
    }
}
