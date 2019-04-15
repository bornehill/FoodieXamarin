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
    public partial class RecipeListPage : ContentPage
    {
        public RecipeListPage()
        {
            InitializeComponent();
        }

        void ChangeStyles_Click(object sender, EventArgs e)
        {
            //Broandcast a message that the cell should update colors
            MessagingCenter.Send(this, "change");
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var recipe = e.SelectedItem as Recipe;

            if (recipe == null)
                return;

            var detailPage = new RecipeDetailPage(recipe);
            await Navigation.PushAsync(detailPage);

            recipeList.SelectedItem = null;
        }
    }
}