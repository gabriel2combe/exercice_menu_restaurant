// Import necessary namespaces
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi;
using WebApi.Data;
using WebApi.Controllers;

// Define the namespace for the controller
namespace WebApi.Controllers
{
    // Define the route and declare this class as a controller
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Declare a private variable for the database context
        private readonly RestaurantDbContext _context;

        // Declare a list of users
        public readonly List<User> _users = new List<User>
        {

        };

        // Constructor for the UserController, takes a RestaurantDbContext as a parameter
        public UserController(RestaurantDbContext context)
        {
            _context = context;  // Assign the incoming context to the private _context variable
        }

        // HTTP GET method to get a specific user by id
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);  // Find the user in the database

            if (user == null)  // If no user is found...
            {
                return NotFound();  // Return a NotFound status code
            }

            return user;  // If a user is found, return the user
        }


        // HTTP GET method to get all users and their restaurants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            // Fetch all users from the database asynchronously, including their associated restaurants
            return await _context.Users.Include(u => u.Restaurants).ToListAsync();
        }


    }
}
