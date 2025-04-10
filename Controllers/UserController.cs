using Microsoft.AspNetCore.Mvc;

namespace TASK_UI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
