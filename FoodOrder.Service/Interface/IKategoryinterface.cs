using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Service.Interface
{
    public interface IKategoryinterface
    {
        Task<List<Category>> GetKategoriyalar();
        Task<Category> GetKategoriya(Guid id);
        Task<Category> AddKategoriya(Category categorys);
        Task<Category> UpdateKategoriya(Category categorys);
        Task DeleteCategoriya(Guid id);

    }
}
