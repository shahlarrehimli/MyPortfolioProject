using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
