using Microsoft.AspNetCore.Mvc;

namespace Notepad.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
