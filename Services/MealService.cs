using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Services
{
    public class MealService
    {
        private readonly HttpClient _client;
        private readonly RestaurantDbContext _context;

        public MealService(RestaurantDbContext context)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://www.themealdb.com/");
            _context = context;
        }

        public async Task<List<ApiMealResponse>> GetMealFromExternalApi(string name)
        {
            var response = await _client.GetAsync($"api/json/v1/1/search.php?s={name}");
            if (response.IsSuccessStatusCode)
            {
                var mealJson = await response.Content.ReadAsStringAsync();
                var mealsResponse = JsonConvert.DeserializeObject<Meals>(mealJson);

                if (mealsResponse?.meals == null || !mealsResponse.meals.Any())
                {
                    Console.WriteLine("No meals found");
                    return null;
                }

                // Return up to 5 meals
                var apiMeals = mealsResponse.meals.Take(5).ToList();
                return apiMeals;
            }


            return null;
        }

        public async Task AddMealToDatabase(string name, int menuId)
        {
            // Fetch meals from the external API
            var apiMeals = await GetMealFromExternalApi(name);

            if (apiMeals != null && apiMeals.Any())
            {
                // Take the first meal from the response
                var apiMeal = apiMeals.First();

                // Create a new Meal object and map the properties from the ApiMealResponse
                var meal = new Meal
                {
                    Name = apiMeal.strMeal,
                    MenuId = menuId,
                    // Map other properties as needed
                };

                // Add the meal to the database
                _context.Meals.Add(meal);

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
        }


    }
}
