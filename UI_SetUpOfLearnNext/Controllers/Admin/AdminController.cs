using DataAccessLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace UI_SetUpOfLearnNext.Controllers.AnimePage
{
    public class AdminController : Controller
    {
        private readonly ICourseRepositorys _course;
        public AdminController(ICourseRepositorys course)
        {
            _course = course;
        }
        public IActionResult Index()
        {
            var store = _course.GetAll();
            return Json(store);
        }
    }
}
