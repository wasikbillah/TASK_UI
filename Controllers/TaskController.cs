using Microsoft.AspNetCore.Mvc;

namespace TASK_UI.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
