using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace restaurant
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Homepage : TabbedPage
	{
		public Homepage()
		{
			InitializeComponent();
		}
	}
}