using Microsoft.AspNetCore.Mvc;

namespace TREK_Web_Diploma.Controllers
{
    public class MultipleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
