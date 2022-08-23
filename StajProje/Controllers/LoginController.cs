using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StajProje.Models.Entity;


namespace StajProje.Controllers
{

    public class LoginController : Controller
    {
        StajProjeEntities db = new StajProjeEntities();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users users)
        {
            var id = db.Users.Find(users.UserID);

            var usersIndb = db.Users.FirstOrDefault(x => x.Username==users.Username && x.UserPassword==users.UserPassword);
            if (usersIndb != null)
            {
                FormsAuthentication.SetAuthCookie(usersIndb.Username, false);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");   
        }
    }
}