using Microsoft.AspNetCore.Mvc;
using PetPal.Domain.ViewModels.Pet;
using PetPal.Service.Interfaces;
using System.Diagnostics;

namespace PetPal.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePetViewModel model)
        {
            var response = await _petService.Create(model);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return Ok(new { Description = response.Descriptions });
            }
            return BadRequest(new {description = response.Descriptions });
        }
    }
}