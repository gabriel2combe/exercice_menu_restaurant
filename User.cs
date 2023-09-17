using WebApi.Controllers;
namespace WebApi
{

    public class User
    {
// private List<User> _users = new List<User>();


        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Restaurant> _user_restaurants { get; set; }


        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public User(string Firstname, string Lastname, string Email, string Address, string Phone)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Address = Address;
            this.Phone = Phone;
            this._user_restaurants = new List<Restaurant>();
        }

        public User()
        {
            
        }

        public void DisplayRestaurants(User user)
        {
            Console.WriteLine($"Restaurants for user {user.Username}:");
            foreach (var restaurant in user._user_restaurants)
            {
                Console.WriteLine(restaurant.Name);
            }
        }
    }
}
