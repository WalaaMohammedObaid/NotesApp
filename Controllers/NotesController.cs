using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotesApp.Data;
using NotesApp.Models;
using System.Linq;
using System.Threading.Tasks;
namespace NotesApp.Controllers
{
    public class NotesController : Controller
    {
        private readonly AppDbContext _db;

        public NotesController(AppDbContext db)
        {
            _db = db;
        }

        // GET: Notes/Index?search=...
        public async Task<IActionResult> Index(string search)
        {
            ViewData["Search"] = search;

            var notes = _db.Notes.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                notes = notes.Where(n =>
                    n.Title.Contains(search) ||
                    n.Content.Contains(search));
            }

            return View(await notes.OrderByDescending(n => n.CreatedAt).ToListAsync());
        }

        // GET: Notes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Note note)
        {
            if (ModelState.IsValid)
            {
                note.CreatedAt = System.DateTime.Now;
                _db.Notes.Add(note);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(note);
        }

        // GET: Notes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var note = await _db.Notes.FindAsync(id);
            if (note == null) return NotFound();
            return View(note);
        }

        // POST: Notes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Note note)
        {
            if (id != note.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _db.Notes.Update(note);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(note);
        }

        // GET: Notes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var note = await _db.Notes.FindAsync(id);
            if (note == null) return NotFound();
            return View(note);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var note = await _db.Notes.FindAsync(id);
            if (note != null)
            {
                _db.Notes.Remove(note);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
