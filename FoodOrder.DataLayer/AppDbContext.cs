using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Mahsulotlar> Mahsulotlar { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
