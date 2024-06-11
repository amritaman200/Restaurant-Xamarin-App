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
	public partial class CategoriesPage : ContentPage
	{
		CategoriesVM vm = new CategoriesVM();
		public CategoriesPage()
		{
			InitializeComponent();
			this.BindingContext = vm;
		}
	}
}