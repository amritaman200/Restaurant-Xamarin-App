using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace restaurant.Pages.Loader
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Loader : ContentView
	{
		public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
			nameof(IsLoading),
			typeof(bool),
			typeof(Loader),
			false);

		public bool IsLoading
		{
			get => (bool)GetValue(IsLoadingProperty);
			set => SetValue(IsLoadingProperty, value);
		}

		public Loader()
		{
			InitializeComponent();
			BindingContext = this;
		}
	}
}