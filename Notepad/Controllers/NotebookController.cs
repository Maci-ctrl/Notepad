using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Notepad.Models;
using Notepad.Services;

namespace Notepad.Controllers
{
	public class NotebookController : Controller
	{
		private readonly INoteService _db;

		public IActionResult Index()
		{
			var notes = new Note[]
				{
						new Note {Id = 0, Title = "Note 1 Title", Content = "Note 1 Content", DateCreated= new DateTime(2023,05,30,09,30,00), DateUpdated = new DateTime(2023,05,30,09,45,00)},
						new Note {Id = 0, Title = "Note 2 Title", Content = "Note 2 Content", DateCreated= new DateTime(2023,05,31,09,30,00), DateUpdated = new DateTime(2023,05,31,09,45,00)},
						new Note {Id = 0, Title = "Note 3 Title", Content = "Note 3 Content", DateCreated= new DateTime(2023,06,1,09,30,00), DateUpdated = new DateTime(2023,06,1,09,45,00)},
						new Note {Id = 0, Title = "Note 4 Title", Content = "Note 4 Content", DateCreated= new DateTime(2023,06,2,09,30,00), DateUpdated = new DateTime(2023,06,2,09,45,00)},
				};
			return View(notes);
		}

		public NotebookController(INoteService db)
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
			var model = _db.Get(id);
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Note note)
		{
			return View();
		}


		[HttpGet]
		public IActionResult Delete(int id)
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
		public IActionResult Delete(int id, IFormCollection form)
		{
			_db.Delete(id);

			return RedirectToAction("Index");
		}
	}
}

