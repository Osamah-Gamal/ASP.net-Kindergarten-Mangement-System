using Kindergarten.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarten.Controllers
{
    public class ChangePasswordController : Controller
    {

        //-------------
        private readonly AccountContext _DB_Uesr;
        public ChangePasswordController(AccountContext DB_Uesr)
        {
            _DB_Uesr = DB_Uesr;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Signup n_user)
        {
            string uname = TempData["Username"].ToString();

            string username = uname;

            string confirmpassword = n_user.Password;


            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(confirmpassword))
            {
                return View();
            }


            var user = _DB_Uesr.Users.FirstOrDefault(u => u.Username == n_user.Username);

            if (user != null)
            {
                if (n_user.Password == confirmpassword)
                {
                    user.Password = n_user.Password;
                    _DB_Uesr.SaveChanges();


                    /*---------- Go To Another Page by(Redirect)--------*/
                    return View();
                }
                else
                {

                    ModelState.AddModelError("ConfirmPassword", "Password is mach...!");

                }

            }


            TempData["Username"] = username;

            return View();


        }
    }
}
