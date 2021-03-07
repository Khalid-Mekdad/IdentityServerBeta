using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StateOfTravel.Core.Aggregates;

namespace StateOfTravel.Quickstart.Account
{
    public class RegistrationController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public RegistrationController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ApplicationUser user)
        {
            var result = _userManager.CreateAsync(user);


            return View();
        }
    }
}
