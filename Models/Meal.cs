using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Ingredients { get; set; }
        public string? Reference { get; set; }

        // Foreign Key
        [ForeignKey("Menu")]
        public int MenuId { get; set; }


    }
}
