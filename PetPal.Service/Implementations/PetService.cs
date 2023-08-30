using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PetPal.DAL.Interfaces;
using PetPal.Domain.Entity;
using PetPal.Domain.Enum;
using PetPal.Domain.Response;
using PetPal.Domain.ViewModels.Pet;
using PetPal.Service.Interfaces;

namespace PetPal.Service.Implementations
{
    public class PetService : IPetService
    {
        private readonly IBaseRepository<PetEntity> _petRepository;
        private ILogger<PetService> _logger;

        public PetService(IBaseRepository<PetEntity> petRepository, ILogger<PetService> logger)
        {
            _petRepository = petRepository;
            _logger = logger;
        }

        public async Task<IBaseResponse<PetEntity>> Create(CreatePetViewModel model)
        {
            try
            {
                _logger.LogInformation($"Запрос на создание карточки питомца - {model.Name}");

                var pet = await _petRepository.GetAll()
                    .Where(x => x.Kind == model.Kind && x.OwnerName == model.OwnerName)
                    .FirstOrDefaultAsync(x => x.Name == model.Name);

                if (pet != null)
                {
                    return new BaseResponse<PetEntity>()
                    {
                        Descriptions = "Текущая карточка питомца уже существует",
                        StatusCode = StatusCode.PetIsHasAlready
                    };
                }

                pet = new PetEntity()
                {
                    Name = model.Name,
                    Kind = model.Kind,
                    OwnerName = model.OwnerName,
                    Description = model.Description
                };

                await _petRepository.Create(pet);
                return new BaseResponse<PetEntity>()
                {
                    Descriptions = "Карточка питомца создалась",
                    StatusCode = StatusCode.OK
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[PetService.Create]: {ex.Message}" );
                return new BaseResponse<PetEntity>()
                {
                    Descriptions = $"{ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
