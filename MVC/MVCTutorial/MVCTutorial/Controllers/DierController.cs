using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class DierController : Controller
    {
        // GET: DierController
        public ActionResult Index()
        {
            DierRepository _repo = new DierRepository();
            return View(_repo.GetAll());
        }

        // GET: DierController/Details/5
        public ActionResult Details(string benaming)
        {
            DierRepository _repo = new DierRepository();
            return View(_repo.GetByBenaming(benaming));
        }

        // GET: DierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DierController/Create
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

        // GET: DierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DierController/Edit/5
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

        // GET: DierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DierController/Delete/5
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
