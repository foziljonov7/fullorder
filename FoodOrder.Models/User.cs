using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class User
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FISH { get; set; }
        [Required]
        public string Nomer { get; set; }
        public string Manzil { get; set; }
        public List<Mahsulotlar> Savatcha { get; set; }
    }
}
