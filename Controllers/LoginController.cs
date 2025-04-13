using Microsoft.AspNetCore.Mvc;

namespace TASK_UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
