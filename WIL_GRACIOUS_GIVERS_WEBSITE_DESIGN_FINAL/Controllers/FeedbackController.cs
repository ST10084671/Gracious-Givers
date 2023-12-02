using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WIL_PROJECT_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: FeedbackController
        public ActionResult Index()
        {
            return View();
        }

    }
}
