using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController : ControllerBase
{
    public readonly List<Restaurant> _restaurants = new List<Restaurant>();
    public readonly List<User> _users;

    public RestaurantController()
    {
        var userController = new UserController();
        _users = userController._users.ToList();

        var newRestaurant = new Restaurant(1, "New Restaurant", "123 Main St", "555-555-5555", "http://www.newrestaurant.com", _users[0]);
        var newRestaurant2 = new Restaurant(2, "N Reant", "541 Main St", "558-588-8855", "ewrant.com", _users[1]);

        // Initialize the Restaurants property of the first user
        _users[1]._user_restaurants.Add(newRestaurant);
        _users[2]._user_restaurants.Add(newRestaurant2);
        _users[1]._user_restaurants.Add(newRestaurant2);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
        return _restaurants;
    }

    [HttpGet("{userId}")]
    public ActionResult<Restaurant> GetByUserId(int userId)
    {
        var restaurants = _restaurants.Find(u => u.User.Id == userId);
        if (restaurants == null)
        {
            return NotFound();
        }
        return restaurants;
    }

    [HttpPost]
    public IActionResult CreateRestaurant([FromBody] Restaurant restaurant, int userId)
    {
        User user = _users.Find(u => u.Id == userId);
        if (user == null)
        {
            return NotFound();
        }

        restaurant.User = user;
        _restaurants.Add(restaurant);

        return Ok("Restaurant créé avec succès !");
    }
}

