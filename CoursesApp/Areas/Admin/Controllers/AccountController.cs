using System.Web.Mvc;
using CoursesApp.Areas.Admin.Models;
using CoursesApp.Services;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginInfo)
        {
            var adminService = new AdminService();
            var isLoggedIn = adminService.Login(loginInfo.Email, loginInfo.Password);
            if (isLoggedIn)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                loginInfo.Message = "Email or password is incorrect";
                return View(loginInfo);
            }
        }
    }
}