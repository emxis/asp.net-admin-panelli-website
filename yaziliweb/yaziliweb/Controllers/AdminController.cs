using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yaziliweb.Models.siniflar;

namespace yaziliweb.Controllers
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
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.bg1 = x.bg1;
            ag.baslik = x.baslik;
            ag.buttongiris = x.buttongiris;
            ag.baslikBg2 = x.baslikBg2;
            ag.baslikBg4 = x.baslikBg4;
            ag.hakkimizdaAciklama = x.hakkimizdaAciklama;
            ag.amacimizYazi = x.amacimizYazi;
            ag.footer = x.footer;
            ag.aciklamaFoto = x.aciklamaFoto;
            ag.ozellik1 = x.ozellik1;
            ag.ozellik2 = x.ozellik2;
            ag.ozellik3 = x.ozellik3;
            ag.flexImage1 = x.flexImage1;
            ag.flexImage2 = x.flexImage2;
            ag.flexImage3 = x.flexImage3;
            ag.flexYazi1 = x.flexYazi1;
            ag.flexYazi2 = x. flexYazi2;
            ag.flexYazi3 = x. flexYazi3;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}