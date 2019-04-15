using FoodieXamarin.Models;
using FoodieXamarin.ViewsCell;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieXamarin.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        DataTemplate recipeTemplate;
        DataTemplate recommendedTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedTemplate = new DataTemplate(typeof(RecommendedRecipeCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;

            if (recipe == null)
                return null;

            return recipe.IsRecommended ? recommendedTemplate : recipeTemplate;
        }
    }
}
