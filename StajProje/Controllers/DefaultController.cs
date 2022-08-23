using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StajProje.Models.Entity;  

namespace StajProje.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {

        StajProjeEntities db = new StajProjeEntities();

        [HttpGet]
        public ActionResult Index()
        {

            List<SelectListItem> degerler = (from i in db.Calls.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CustomerName,
                                                 Value = i.CustomerName.ToString(),
                                             }).ToList();
            ViewBag.dgr = degerler;

            List<SelectListItem> degerler2 = (from i in db.Users.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Username,
                                                 Value = i.Username.ToString(),
                                             }).ToList();
            ViewBag.dgr2 = degerler2;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Jobs p1)
        {
            var ktg = db.Calls.Where(m => m.CustomerName == p1.Musteri).FirstOrDefault();
            p1.Calls = ktg;

            db.Jobs.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

            //Jobs model = new Jobs();
            //model.Cari = form["Cari"].Trim();
            //model.CariAdres = form["CariAdres"].Trim();
            //model.Gruplar = form["Gruplar"].Trim();
            //model.Teknisyenler = form["Teknisyenler"].Trim();
            //db.Jobs.Add(model);
            //db.SaveChanges();
        }

        public ActionResult Personel()
        {
            var personelList = db.Jobs.ToList();
            return View(personelList);
        }

        public ActionResult Cagrilar()
        {
            var callList = db.Calls.ToList();
            return View(callList);
        }

        public ActionResult Ayarlar()
        {
            var userList = db.Users.ToList();
            return View(userList);
        }

        [Authorize(Roles = "1")]
        public ActionResult Admin()
        {
            var AdminList = db.Jobs.ToList();
            return View(AdminList);
        }

        public ActionResult SIL(int id)
        {
            var job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
            db.SaveChanges();
            return RedirectToAction("Personel");
        }
        public ActionResult SILA(int id)
        {
            var job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        public ActionResult SILAA(int id)
        {
            var user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Ayarlar");
        }
        public ActionResult SILC(int id)
        {
            var call = db.Calls.Find(id);
            db.Calls.Remove(call);
            db.SaveChanges();
            return RedirectToAction("Cagrilar");
        }
    }
}