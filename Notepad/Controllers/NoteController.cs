using Microsoft.AspNetCore.Mvc;

namespace Notepad.Controllers
{
	public class NoteController : Controller
	{
		private readonly INotepadService _db;

		public RestaurantsController(INotepadService db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Note note)
		{
			return View();
		}
	}
}
