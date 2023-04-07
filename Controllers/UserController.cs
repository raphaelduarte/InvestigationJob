using InvestigationJob.Models.Interface;
using InvestigationJob.Models.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InvestigationJob.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
