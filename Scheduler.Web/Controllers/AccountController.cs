using System.Web.Mvc;
using Scheduler.Web.Models;
using System.Web.Security;

namespace Scheduler.Web.Controllers
{
    public class AccountController : Controller
    {
        private const string UserName = "admin";
        private const string Password = "password";

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid && model.UserName == UserName && model.Password == Password)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid username or password.");
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
