using kisiselweb.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kisiselweb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public  ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag= c.AnaSayfas.Find(x.id);
            ag.ad = x.ad;
            ag.aciklama = x.aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult sosyal()
        {
            var deger = c.Sosyals.ToList();
            return View(deger);
        }
    }
}