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
    }
}