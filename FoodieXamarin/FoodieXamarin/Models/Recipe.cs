namespace FoodieXamarin.Models
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string PreparationTime { get; set; }
        public string CookTime { get; set; }
        public int NumberOfServings { get; set; }
        public bool WillMakeAgain { get; set; }
        public string MealType { get; set; }
        public string Difficulty { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string ImageName { get; set; }
    }
}
