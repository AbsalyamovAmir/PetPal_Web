using Microsoft.AspNetCore.Cors.Infrastructure;
using PetPal.DAL.Interfaces;
using PetPal.DAL.Repositories;
using PetPal.Domain.Entity;
using PetPal.Service.Implementations;
using PetPal.Service.Interfaces;

namespace PetPal
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<PetEntity>, PetRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProfileService, ProfileService>();
        }
    }
}
