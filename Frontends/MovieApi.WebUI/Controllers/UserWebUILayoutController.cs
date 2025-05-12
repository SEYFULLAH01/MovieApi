using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class UserWebUILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
