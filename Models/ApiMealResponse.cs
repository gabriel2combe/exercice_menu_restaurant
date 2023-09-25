namespace WebApi.Models
{
    public class ApiMealResponse
    {
        public string idMeal { get; set; }
        public string strMeal { get; set; }
        public string strDrinkAlternate { get; set; }
        public string strCategory { get; set; }
        public string strArea { get; set; }
        public string strInstructions { get; set; }
        public string strMealThumb { get; set; }
        public string strTags { get; set; }
        public string strYoutube { get; set; }
        // Add all the other properties as needed
    }

    public class Meals
    {
        public List<ApiMealResponse> meals { get; set; }
        
    }

}
