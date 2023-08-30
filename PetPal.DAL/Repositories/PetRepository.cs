using PetPal.Dal;
using PetPal.DAL.Interfaces;
using PetPal.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPal.DAL.Repositories
{
    public class PetRepository : IBaseRepository<PetEntity>
    {
        private readonly AppDBContext _dbContext;
        public PetRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(PetEntity entity)
        {
            await _dbContext.Pets.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(PetEntity entity)
        {
            _dbContext.Pets.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<PetEntity> GetAll()
        {
            return _dbContext.Pets;
        }

        public async Task<PetEntity> Update(PetEntity entity)
        {
            _dbContext.Pets.Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
