using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApi.Models;
using WebApi;

public class Restaurant
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Category { get; set; }
    public string? WebSite { get; set; }
    public string? Image { get; set; }
    // Foreign Key
    [ForeignKey("User")]
    public int UserId { get; set; }
    public List<Menu> Menus { get; set; }



    public Restaurant(int id, string name, string category, string webSite, string image, int userId)
    {
        Id = id;
        Name = name;
        Category = category;
        WebSite = webSite;
        Image = image;
        UserId = userId;
        Menus = new List<Menu>();
    }
}
