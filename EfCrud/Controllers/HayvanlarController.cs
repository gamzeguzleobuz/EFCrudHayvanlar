using EfCrud.Data;
using Microsoft.AspNetCore.Mvc;

namespace EfCrud.Controllers
{
    public class HayvanlarController : Controller
    {
        private readonly HayvanContext db;

        public HayvanlarController(HayvanContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Hayvanlar.ToList());
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Yeni(Hayvan hayvan)
        {
            if (ModelState.IsValid)
            {
                db.Hayvanlar.Add(hayvan);
                db.SaveChanges();
                return RedirectToAction("Index", new { Durum = "Eklendi" }); 
            }
            return View();
        }


        public IActionResult Sil(int id)
        {
            var hayvan = db.Hayvanlar.Find(id);
            if (hayvan == null)
                return NotFound();

            return View(hayvan);
        }

        [ActionName("Sil")]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SilOnay(int id)
        {
            var hayvan = db.Hayvanlar.Find(id);
            if (hayvan == null)
                return NotFound();


            db.Hayvanlar.Remove(hayvan);
            db.SaveChanges();
            return RedirectToAction("Index", new { Durum = "Silindi" }); 
        }


        public IActionResult Duzenle(int id)
        {
            var hayvan = db.Hayvanlar.Find(id);
            if (hayvan == null)
                return NotFound();
            
            return View(hayvan);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Duzenle(Hayvan hayvan)
        {
            if (!db.Hayvanlar.Any(h => h.Id == hayvan.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid) //ad boş girilmiş olabilir, 50 karakterden fazla girilmiş olabilir geçerliliğini kontrol et
            {
                db.Hayvanlar.Update(hayvan);
                db.SaveChanges();
                return RedirectToAction("Index", new { Durum = "Duzenlendi" });   
            }

            return View();
        }
    }
}
