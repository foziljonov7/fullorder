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
    public class MahsulotRepository : IMahsulotlarinterface
    {
        private readonly AppDbContext _dbContext;
        public MahsulotRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Task<Mahsulotlar> AddMahsulotlar(Mahsulotlar mahsulotlar)
        {
            _dbContext.Mahsulotlar.Add(mahsulotlar);
            _dbContext.SaveChanges();

            return Task.FromResult(mahsulotlar);
        }

        public Task DeleteMahsulotlar(Guid Id)
        {
            Mahsulotlar mahsulotlar = _dbContext.Mahsulotlar.
                FirstOrDefault(m => m.Id == Id);
            _dbContext.Remove(mahsulotlar);
            return Task.FromResult(0);
        }

        public Task<Mahsulotlar> GetMahsulotlar(Guid id)
            => _dbContext.Mahsulotlar.FirstOrDefaultAsync(m => m.Id == id);

        public Task<List<Mahsulotlar>> GetMahsulotlars()
          =>_dbContext.Mahsulotlar.ToListAsync();

        public Task<Mahsulotlar> UpdateMahsulotlar(Mahsulotlar mahsulotlar)
        {
            throw new NotImplementedException();
        }
    }
}
