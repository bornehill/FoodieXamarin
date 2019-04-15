using FoodieXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodieXamarin.ViewsCell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecommendedRecipeCell : ViewCell
	{
		public RecommendedRecipeCell ()
		{
			InitializeComponent ();

            overAllContent.Resources["BannerStyle"] = App.Current.Resources["RecommendedBannerStyle"];
            overAllContent.Resources["CellContentStyle"] = App.Current.Resources["overAllCellContentStyle"];
            overAllContent.Resources["NameStyle"] = App.Current.Resources["RecipeNameStyle"];
            overAllContent.Resources["DetailStyle"] = App.Current.Resources["cellPrepDetailStyle"];

            MessagingCenter.Subscribe<RecipeListPage>(this, "change", (obj) => ChangeStyles());
        }

        bool isBold = true;

        void ChangeStyles()
        {
            isBold = !isBold;
            if (isBold)
            {
                overAllContent.Resources["BannerStyle"] = overAllContent.Resources["BoldRecommendedBannerStyle"];
                overAllContent.Resources["CellContentStyle"] = overAllContent.Resources["BoldOverAllCellContentStyle"];
                overAllContent.Resources["NameStyle"] = overAllContent.Resources["BoldRecipeNameStyle"];
                overAllContent.Resources["DetailStyle"] = overAllContent.Resources["BoldCellPrepDetailsStyle"];
                return;
            }

            overAllContent.Resources["BannerStyle"] = App.Current.Resources["RecommendedBannerStyle"];
            overAllContent.Resources["CellContentStyle"] = App.Current.Resources["overAllCellContentStyle"];
            overAllContent.Resources["NameStyle"] = App.Current.Resources["RecipeNameStyle"];
            overAllContent.Resources["DetailStyle"] = App.Current.Resources["cellPrepDetailStyle"];
        }
	}
}