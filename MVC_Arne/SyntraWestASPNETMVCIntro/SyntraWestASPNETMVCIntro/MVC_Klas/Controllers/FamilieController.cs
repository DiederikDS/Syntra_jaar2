using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Klas.Services;

namespace MVC_Klas.Controllers
{

    public class FamilieController : Controller
    {
        private JsonFamilieService _jf;
        public FamilieController(JsonFamilieService jsonFamilieService)
        {
            _jf = jsonFamilieService;
        }

        // GET: FamilieController1
        public ActionResult Index()
        {
            return View(_jf.GetFamilies());
        }

        // GET: FamilieController1/Details/5
        public ActionResult Details(string id)
        {
            return View(_jf.GetFamilieByName(id));
        }

        // GET: FamilieController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilieController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilieController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamilieController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilieController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamilieController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
