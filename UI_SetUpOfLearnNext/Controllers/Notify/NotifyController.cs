using Microsoft.AspNetCore.Mvc;

namespace UI_SetUpOfLearnNext.Controllers.Notify
{
    public class NotifyController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("HostNotifaction");
        }

        public IActionResult HostNotifaction()
        {

            return Json(new { suceess = "added" });
        }

        public IActionResult Binder()
        {

            return Json(new { suceess = "added" });
        }
    }
}
