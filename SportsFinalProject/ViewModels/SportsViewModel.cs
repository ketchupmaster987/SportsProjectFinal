using SportsLibrary;

namespace SportsFinalProject.ViewModels
{
    public class SportsViewModel
    {
        
        Sport s;

        public SportsViewModel(Sport s)
        {
            this.s = s;

        }

        public String Name { get
            {
                return s.Name;
            }
        }

        public String Description { get
            {
                return s.Description;
            } }
    }
}
