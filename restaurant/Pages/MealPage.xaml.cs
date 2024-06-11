using restaurant.Pages.ModalPages;
using restaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace restaurant.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MealPage : ContentPage
	{
		MealsVM vm = new MealsVM();
		public MealPage()
		{
			InitializeComponent();
			this.BindingContext = vm;
		}

		private async void GetDetail(object sender, EventArgs e)
		{
			this.IsEnabled = false;
			var te = (TappedEventArgs)e;
			string mealId = (string)te.Parameter;

			await Navigation.PushModalAsync(new MealDetail(mealId));
			this.IsEnabled = true;
		}

		
	}
}