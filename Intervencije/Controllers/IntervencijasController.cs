using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Intervencije.Data;
using Intervencije.Models;
using Microsoft.AspNetCore.Authorization;

namespace Intervencije.Controllers
{
    [Authorize]
    public class IntervencijasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IntervencijasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Intervencijas

        public IActionResult Index()
        {
            return View();
        }
        // GET: Intervencijas
        public async Task<IActionResult> List()
        {
            return View(await _context.DbIntervencija.ToListAsync());
        }

        // GET: Intervencijas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intervencija = await _context.DbIntervencija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (intervencija == null)
            {
                return NotFound();
            }

            return View(intervencija);
        }

        // GET: Intervencijas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Intervencijas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Datum,FkUser,FkAkcija,FkPlaza,Hitna,Policija,Vatrogasci,ImeZrtve,PrezimeZrtve,GodineZrtve,Ozljeda,OpisAkcije")] Intervencija intervencija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(intervencija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(intervencija);
        }

        // GET: Intervencijas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intervencija = await _context.DbIntervencija.FindAsync(id);
            if (intervencija == null)
            {
                return NotFound();
            }
            return View(intervencija);
        }

        // POST: Intervencijas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Datum,FkUser,FkAkcija,FkPlaza,Hitna,Policija,Vatrogasci,ImeZrtve,PrezimeZrtve,GodineZrtve,Ozljeda,OpisAkcije")] Intervencija intervencija)
        {
            if (id != intervencija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(intervencija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntervencijaExists(intervencija.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(intervencija);
        }

        // GET: Intervencijas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intervencija = await _context.DbIntervencija
                .FirstOrDefaultAsync(m => m.Id == id);
            if (intervencija == null)
            {
                return NotFound();
            }

            return View(intervencija);
        }

        // POST: Intervencijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var intervencija = await _context.DbIntervencija.FindAsync(id);
            _context.DbIntervencija.Remove(intervencija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntervencijaExists(int id)
        {
            return _context.DbIntervencija.Any(e => e.Id == id);
        }
    }
}
