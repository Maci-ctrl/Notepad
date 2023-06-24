using Microsoft.AspNetCore.Mvc;

namespace Notepad.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string firstName, string lastName, string email, DateOnly birthDate)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            return View();
        }
    }
}
