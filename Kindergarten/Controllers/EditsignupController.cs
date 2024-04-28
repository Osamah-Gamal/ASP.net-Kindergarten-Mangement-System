using kinder.Data;
using kinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kinder.Controllers
{
    public class EditsignupController : Controller
    {
        private readonly kinderContext _context;

        public EditsignupController(kinderContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: Singups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Singup == null)
            {
                return NotFound();
            }

            var singup = await _context.Singup.FindAsync(id);
            if (singup == null)
            {
                return NotFound();
            }
            return View(singup);
        }

        // POST: Singups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("UserId,FullName,Age,CardNumber,Address,Phone,UserName,Password,ConfirmPassword,AnswerSecurty")] Signup singup)
        {
            if (id != singup.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(singup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SingupExists(singup.UserId))
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
            return View(singup);
        }

        private bool SingupExists(object userId)
        {
            throw new NotImplementedException();
        }
    }
}
