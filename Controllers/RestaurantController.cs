// Import necessary namespaces
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApi.Controllers;
using WebApi.Data;
using WebApi.Models;

// Define the namespace for the controller
namespace WebApi.Controllers
{
    // Define the route and declare this class as a controller
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        // Declare a private variable for the database context
        private readonly RestaurantDbContext _context;

        // Constructor for the RestaurantController, takes a RestaurantDbContext as a parameter
        public RestaurantController(RestaurantDbContext context)  // DependencyInjection
        {
            _context = context;  // Assign the incoming context to the private _context variable
        }

        // HTTP GET method to get all restaurants
        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> Get()
        {
            return _context.Restaurants.ToList();  // Get restaurants from the DbContext
        }

        // HTTP GET method to get restaurants by user ID
        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<Restaurant>> GetByUserId(int userId)
        {
            var restaurants = _context.Restaurants.Where(r => r.UserId == userId).ToList();
            if (restaurants == null || !restaurants.Any())
            {
                return NotFound();  // If no restaurants are found, return a NotFound status code
            }
            return restaurants;  // If restaurants are found, return the restaurants
        }

        // HTTP POST method to create a new restaurant
        [HttpPost]
        public IActionResult CreateRestaurant([FromBody] Restaurant restaurant)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == restaurant.UserId);  // Get user from the DbContext
            if (user == null)
            {
                return NotFound();  // If no user is found, return a NotFound status code
            }
            restaurant.UserId = user.Id;
            _context.Restaurants.Add(restaurant);  // Add restaurant to the DbContext
            _context.SaveChanges();  // Save changes to the DbContext

            return Ok("Restaurant créé avec succès !");  // Return a success message
        }

        // HTTP GET method to get meals by restaurant ID
        [HttpGet("{restaurantId}/meals")]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals(int restaurantId)
        {
            Debug.WriteLine($"Fetching restaurant with ID: {restaurantId}");
            var restaurant = await _context.Restaurants.Include(r => r.Menus)
                .ThenInclude(m => m.Meals)
                .FirstOrDefaultAsync(r => r.Id == restaurantId);

            if (restaurant == null)
            {
                Debug.WriteLine($"No restaurant found with ID: {restaurantId}");
                return NotFound();  // If no restaurant is found, return a NotFound status code
            }

            Debug.WriteLine($"Restaurant found. Fetching meals...");
            var meals = restaurant.Menus.SelectMany(m => m.Meals).ToList();

            if (meals == null || !meals.Any())
            {
                Debug.WriteLine($"No meals found for restaurant with ID: {restaurantId}");
                return NotFound();  // If no meals are found, return a NotFound status code
            }

            Debug.WriteLine($"Meals found: {meals.Count}");
            return meals;  // If meals are found, return the meals
        }
    }
}
