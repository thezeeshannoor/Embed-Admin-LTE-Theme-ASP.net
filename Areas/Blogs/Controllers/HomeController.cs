using Microsoft.AspNetCore.Mvc;

namespace Admin_Pannel_Embeded.Areas.Blogs.Controllers
{
    [Area("Blogs")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
