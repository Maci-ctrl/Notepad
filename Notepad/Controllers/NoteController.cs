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

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var model =  _db.Get(id);
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Note note)
		{
			return View();
		}


		[HttpGet]
		public async IActionResult Delete(int id)
		{
			var model = _db.Get(id);

			if (model == null)
			{
				return View("NotFound");
			}
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(int id)
		{
			_db.Delete(id);

			return RedirectToAction("Index");
		}
	}
}

