using WebApi;

public class Restaurant
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }
    public User User { get; set; }

    // Constructor
    public Restaurant(int id, string name, string address, string phone, string website, User user)
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
        Website = website;
        User = user;
    }

    // Some methods
    public void Open()
    {
        Console.WriteLine("The restaurant is now open!");
    }

    public void Close()
    {
        Console.WriteLine("The restaurant is now closed.");
    }

    // New method
    public void NewRestaurant(string name, string address, string phone, string website, User user)
    {
        // Create a new restaurant object with the specified properties
        Restaurant newRestaurant = new Restaurant(Id + 1, name, address, phone, website, user);

        // Add the new restaurant to the user's list of restaurants
        User._user_restaurants.Add(newRestaurant);

        Console.WriteLine($"New restaurant added: {newRestaurant.Name}");
    }
}
