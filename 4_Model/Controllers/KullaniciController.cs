using _4_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4_Model.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            List<Kullanici> modelList = KullaniciList();
            return View(modelList); // data'yı view'a bind ediyoruz...
        }
        private List<Kullanici> KullaniciList()
        {
            List<Kullanici> list = new List<Kullanici>();
            list.Add(new Kullanici { KullaniciAdi = "eyildirim" });
            list.Add(new Kullanici { KullaniciAdi = "bakyol" });
            list.Add(new Kullanici { KullaniciAdi = "ckaratas" });
            list.Add(new Kullanici { KullaniciAdi = "böz" });
            return list;
        }
    }
}