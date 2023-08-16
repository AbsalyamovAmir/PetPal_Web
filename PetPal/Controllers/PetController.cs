using Microsoft.AspNetCore.Mvc;
using PetPal.Domain.ViewModels.Pet;

using System.Diagnostics;

namespace PetPal.Controllers
{
    public class PetController : Controller
    {
        private readonly ILogger<PetController> _logger;

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePetViewModel model)
        {
            return Ok();
        }
    }
}