using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Service.Interface
{
    public interface IMahsulotlarinterface
    {
        Task<List<Mahsulotlar>> GetMahsulotlars();
        Task<Mahsulotlar> GetMahsulotlar(Guid Id);
        Task<Mahsulotlar> AddMahsulotlar(Mahsulotlar mahsulotlar);
        Task<Mahsulotlar> UpdateMahsulotlar(Mahsulotlar mahsulotlar);
        Task DeleteMahsulotlar(Guid Id);
    }
}
