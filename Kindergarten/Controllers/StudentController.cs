using Kid.Data;
using Kid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Kid.Models.DBS;

namespace Kid.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;
        public  StudentController(StudentDbContext context)
        {
            _context = context;
        }

       
      
        [HttpGet]
        public IActionResult Index()
        {
            var employee = _context.students.ToList();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Index(Student stu)
        {
            int Id = 1;
            if (ModelState.IsValid)
            {
                stu = (from ss in _context.students
                       where ss.student_id == Id
                       select ss).FirstOrDefault();

            }
            return View();
        }


       

}
}
