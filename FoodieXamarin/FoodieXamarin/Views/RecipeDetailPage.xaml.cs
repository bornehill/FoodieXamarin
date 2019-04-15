using FoodieXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodieXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailPage : ContentPage
	{
        Recipe SelectedRecipe;

        public RecipeDetailPage (Recipe selectedRecipe)
		{
			InitializeComponent ();

            SelectedRecipe = selectedRecipe;
            BindingContext = selectedRecipe;
        }

        async void EditRecipe_Clicked(object sender, System.EventArgs e)
        {
            var editPage = new NavigationPage(new EditRecipePage(SelectedRecipe));

            await Navigation.PushModalAsync(editPage);
        }
    }
}