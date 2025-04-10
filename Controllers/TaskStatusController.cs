using Microsoft.AspNetCore.Mvc;

namespace TASK_UI.Controllers
{
    public class TaskStatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
