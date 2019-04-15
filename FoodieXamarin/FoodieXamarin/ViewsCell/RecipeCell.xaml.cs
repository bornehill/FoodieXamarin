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
	public partial class RecipeCell : ViewCell
	{
		public RecipeCell ()
		{
			InitializeComponent ();
		}
	}
}