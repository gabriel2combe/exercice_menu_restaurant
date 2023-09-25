using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public byte[]? PasswordHash { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public List<Restaurant> Restaurants { get; set; }


    // Constructor
    public User()
    {
        Restaurants = new List<Restaurant>();
    }

    // Methods
    public void AddRestaurant(Restaurant restaurant)
    {
        Restaurants.Add(restaurant);
        Console.WriteLine($"New restaurant added: {restaurant.Name}");
    }

}
