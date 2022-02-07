using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Mahsulotlar
    {
        [Required]
        [Key]
        public Guid Id { get; set; }    
        [Required]
        public string Nomi { get; set; }
        [Required]
        public string Batafsil { get; set; }
        [Required]
        public double Narxi { get; set; }
        [Required]
        public string Rasmi { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
    }
}
