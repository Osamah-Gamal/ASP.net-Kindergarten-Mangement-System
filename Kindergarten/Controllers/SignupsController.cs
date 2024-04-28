using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kinder.Data;
using kinder.Models;

namespace kinder.Controllers
{
    public class EsitsignupController : Controller
    {
        private readonly kinderContext _context;

        public EsitsignupController(kinderContext context)
        {
            _context = context;
        }

       
        

        // GET: Singups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Singups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FullName,Age,CardNumber,Address,Phone,UserName,Password,ConfirmPassword,AnswerSecurty")] Signup singup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(singup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(singup);
        }

        // GET: Singups/Edit/5
       

        
       

        private bool SingupExists(int? id)
        {
          return (_context.Singup?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
