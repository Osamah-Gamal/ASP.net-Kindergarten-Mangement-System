using Kindergarten.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.Controllers
{
    public class Create_new_studentController : Controller
    {

        public readonly Studentcontext _db;
        public Create_new_studentController(Studentcontext db)
        {
            _db = db;
        }
       


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student stu)
        {
            _db.Items.Add(stu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
