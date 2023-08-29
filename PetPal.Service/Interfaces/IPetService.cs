using PetPal.Domain.Entity;
using PetPal.Domain.Response;
using PetPal.Domain.ViewModels.Pet;

namespace PetPal.Service.Interfaces
{
    public interface IPetService
    {
        Task<IBaseResponse<PetEntity>> Create(CreatePetViewModel model);
    }
}
