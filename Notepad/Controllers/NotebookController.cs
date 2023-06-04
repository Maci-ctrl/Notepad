using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Notepad.Models;
using Notepad.Services;

namespace Notepad.Controllers
{
    public class NotebookController : Controller
    {
        private readonly INoteService _db;

        public async Task<IActionResult> Index()
        {
            var notes = await _db.GetAll();
            return View(notes);
        }

        public NotebookController(INoteService db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Note note)
        {
            try
            {
                await _db.Add(note);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {


                ErrorViewModel addingError = new ErrorViewModel();
                addingError.Message = ex.Message;
                return View("Error", addingError);


            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _db.Get(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Note note)
        {
            if (ModelState.IsValid)
            {
                await _db.Update(note);

                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection form)
        {
            await _db.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await _db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}

