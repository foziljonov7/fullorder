using FoodOrder.DataLayer;
using FoodOrder.Models;
using FoodOrder.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Service.Repository
{
    public class KategorilarRepository : IKategoryinterface
    {
        private readonly AppDbContext _dbContext;
        public KategorilarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public Task<Category> AddKategoriya(Category categorys)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoriya(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetKategorilar(Guid id)
             => _dbContext.Categorys.FirstOrDefaultAsync(m => m.Id == id);

        public Task<List<Category>> GetKategoriya()
        => _dbContext.Categorys.ToListAsync();

        public Task<Category> GetKategoriya(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetKategoriyalar()
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateKategoriya(Category categorys)
        {
            throw new NotImplementedException();
        }
    }
}
