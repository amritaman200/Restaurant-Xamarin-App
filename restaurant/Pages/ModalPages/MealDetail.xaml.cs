using restaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace restaurant.Pages.ModalPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MealDetail : ContentPage
	{
		MealDetailVM vm;
		public MealDetail(string mealId)
		{
			InitializeComponent();
			vm = new MealDetailVM(mealId);
			this.BindingContext = vm;
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}