using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WIL_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Controllers
{
    public class PurposeController : Controller
    {
        // GET: PurposeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PurposeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurposeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurposeController/Create
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

        // GET: PurposeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurposeController/Edit/5
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

        // GET: PurposeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurposeController/Delete/5
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
