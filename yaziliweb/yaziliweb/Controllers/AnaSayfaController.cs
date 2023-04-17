using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yaziliweb.Models.siniflar;

namespace yaziliweb.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        // GET: AnaSayfa
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        
    }
}