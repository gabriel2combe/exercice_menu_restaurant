using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public readonly List<User> _users = new List<User>
        {
            new User
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Doe",
                Email = "johndoe@example.com",
                Address = "123 Main St",
                Phone = "555-555-5555",
                _user_restaurants = new List<Restaurant>{ },
            },

            new User
            {
                Id = 2,
                Firstname = "Jane",
                Lastname = "Doe",
                Email = "janedoe@example.com",
                Address = "456 Main St",
                Phone = "555-555-5555",
                _user_restaurants = new List<Restaurant>{ },
            },
            
            new User
            {
                Id = 3,
                Firstname = "Lo",
                Lastname = "Anne",
                Email = "anne@expl.com",
                Address = "1456 Mall St",
                Phone = "555-787675",
                _user_restaurants = new List<Restaurant>{ },
            }
        };
        public UserController()
        {

        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // Add other HTTP methods (POST, PUT, DELETE) as needed
    }
}
