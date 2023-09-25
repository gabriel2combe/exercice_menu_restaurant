using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models;

namespace WebApi
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }

        public List<Meal> Meals { get; set; }

        public Menu()
        { 
            Meals = new List<Meal>();
        }

    }
}
