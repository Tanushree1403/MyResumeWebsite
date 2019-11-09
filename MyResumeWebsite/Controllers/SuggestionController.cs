using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResumeWebsite.Controllers
{
    public class SuggestionController : Controller
    {
        // GET: Suggestion
        public ActionResult SuggestionMessage()
        {
            return View();
        }
    }
}