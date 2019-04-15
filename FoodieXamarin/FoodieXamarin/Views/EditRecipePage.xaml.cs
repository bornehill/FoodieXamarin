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
	public partial class EditRecipePage : ContentPage
	{
		public EditRecipePage (Recipe recipe)
		{
			InitializeComponent ();
            BindingContext = recipe;
		}

        async void HandleCancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}