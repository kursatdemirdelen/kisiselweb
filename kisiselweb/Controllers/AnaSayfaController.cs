using kisiselweb.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;

namespace kisiselweb.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public PartialViewResult istatistik()
        {
            var deger = c.Istatistiks.ToList();
            return PartialView(deger);
        }
        public PartialViewResult sosyal()
        {
            var deger = c.Sosyals.ToList();
            return PartialView(deger);
        }
    }
}