using Microsoft.AspNetCore.Mvc;
using SportsLibrary;
using SportsFinalProject.ViewModels;

namespace SportsFinalProject.Controllers
{
    public class SportsController : Controller
    {
        Sport s;

        public SportsController()
        {
            this.s = new Sport() { Name = "League of Legends", Description = "Capture the flag with teams of five people"};
        }

        public IActionResult Index()
        {

            return View(new SportsViewModel(s));
        }
    }
}
