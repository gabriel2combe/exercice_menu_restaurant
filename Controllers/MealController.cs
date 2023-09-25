using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
        private readonly RestaurantDbContext _context;
        private readonly MealService _mealService;

        public MealController(RestaurantDbContext context, MealService mealService) // DependencyInjections
        {
            _context = context;
            _mealService = mealService;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<List<ApiMealResponse>>> GetMeals(string name)
        {
            var meals = await _mealService.GetMealFromExternalApi(name);
            if (meals == null || meals.Count == 0)
            {
                return NotFound();
            }
            return meals;
        }

        [HttpPost("{name}")]
        public async Task<IActionResult> AddMeal(string name)
        {
            // default menuId, user input need to be retrieved 
            int menuId = 1;

            await _mealService.AddMealToDatabase(name, menuId);

            return Ok("Meal added successfully!");
        }
    }
}
