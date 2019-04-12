using FoodieXamarin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodieXamarin.Models
{
    public class RecipeData
    {
        static List<Recipe> allRecipes;
        public static List<Recipe> AllRecipes
        {
            get
            {
                if (allRecipes == null)
                {
                    allRecipes = new List<Recipe>
                    {
                        new Recipe
                        {
                            RecipeName="Eggs Benedict",
                            CookTime="24 min",
                            PreparationTime="5 min",
                            NumberOfServings=8,
                            WillMakeAgain=true,
                            MealType=MealType.BreakFast.ToString(),
                            Difficulty=DifficultyType.Easy.ToString(),
                            Directions="1. Fill a large saucepan with about 4 inches of water",
                            Ingredients="1 tablespoon white vinegar"+Environment.NewLine+
                            "8 large eggs\nHollandaise Sauce"+Environment.NewLine+
                            "1/2 pound (16 slices) Canadian bacon"+Environment.NewLine+
                            "4 English muffins, split in half, toasted",
                            ImageName = "eggsBenedict.png"
                        },
                        new Recipe
                        {
                            RecipeName="Blueberry Muffins",
                            CookTime="25 min",
                            PreparationTime="10 min",
                            NumberOfServings=12,
                            WillMakeAgain=false,
                            MealType=MealType.BreakFast.ToString(),
                            Difficulty=DifficultyType.Medium.ToString(),
                            Directions="Preheat oven to 350 degrees. \n\nCombine dry ingredients",
                            Ingredients="1 a cup whole wheat white flour\n1 tbsp baking powder",
                            ImageName = "muffinBlueberry.png"
                        },
                        new Recipe
                        {
                            RecipeName="Burguer",
                            CookTime="20 min",
                            PreparationTime="5 min",
                            NumberOfServings=4,
                            WillMakeAgain=true,
                            MealType=MealType.Lunch.ToString(),
                            Difficulty=DifficultyType.Medium.ToString(),
                            Directions="1. Toaste meat",
                            Ingredients="1 burguer meat",
                            ImageName = "burger.png"
                        }
                    };
                }
                return allRecipes;
            }
            set
            {
                allRecipes = value;
            }
        }

        static List<RecipeGrouping> allRecipesGrouped;
        public static List<RecipeGrouping> AllRecipesGrouped
        {
            get
            {
                if (allRecipesGrouped == null)
                {
                    var easyGrouping = new RecipeGrouping("Easy", "E");
                    easyGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Easy.ToString())));

                    var mediumGrouping = new RecipeGrouping("Medium", "M");
                    mediumGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Medium.ToString())));

                    var hardGrouping = new RecipeGrouping("Hard", "H");
                    hardGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Hard.ToString())));

                    allRecipesGrouped = new List<RecipeGrouping>
                    {
                        easyGrouping,
                        mediumGrouping,
                        hardGrouping
                    };
                }
                return allRecipesGrouped;
            }
        }

        #region Generic grouping
        static List<ListViewGrouping<Recipe>> allRecipesListGrouped;
        public static List<ListViewGrouping<Recipe>> AllRecipesListGrouped
        {
            get
            {
                if (allRecipesGrouped == null)
                {
                    var easyGrouping = new ListViewGrouping<Recipe>("Easy", "E");
                    easyGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Easy.ToString())));

                    var mediumGrouping = new ListViewGrouping<Recipe>("Medium", "M");
                    mediumGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Medium.ToString())));

                    var hardGrouping = new ListViewGrouping<Recipe>("Hard", "H");
                    hardGrouping.AddRange(RecipeData.AllRecipes.Where(r => r.Difficulty.Equals(DifficultyType.Hard.ToString())));

                    allRecipesListGrouped = new List<ListViewGrouping<Recipe>>
                    {
                        easyGrouping,
                        mediumGrouping,
                        hardGrouping
                    };
                }
                return allRecipesListGrouped;
            }
        }
        #endregion
    }
}
