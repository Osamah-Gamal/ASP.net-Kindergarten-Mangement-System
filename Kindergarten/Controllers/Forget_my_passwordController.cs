using Kindergarten.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.Controllers
{
    public class Forget_my_passwordController : Controller
    {


        //-------------
        private readonly AccountContext _DB_Uesr;
        public Forget_my_passwordController(AccountContext DB_Uesr)
        {
            _DB_Uesr = DB_Uesr;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //------------
        public ActionResult Index(Signup n_user)
        {

            // قراءة القيم المدخلة من الصفحة
            string username = Request.Form["Username"];
            string password = Request.Form["Password"];

            // التحقق من وجود المستخدم في قاعدة البيانات
            bool usernameExists = _DB_Uesr.Users.Any(u => u.Username == username);
            bool passwordExists = _DB_Uesr.Users.Any(u => u.Password == password);

            if (usernameExists && passwordExists)
            {


                // تخزين اسم المستخدم في TempData
                TempData["Username"] = username;


                return RedirectToAction("Index", "Change_Password");

            }
            else
            {
                if (!usernameExists)
                {
                    ModelState.AddModelError("Username", "This username not correct...!");
                }
                if (!passwordExists)
                {
                    ModelState.AddModelError("Password", "This password not correct...!");
                }
                return View();
            }


        }
    }
}
