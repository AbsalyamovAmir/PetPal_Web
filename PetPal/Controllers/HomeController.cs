using Microsoft.AspNetCore.Mvc;

namespace PetPal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}