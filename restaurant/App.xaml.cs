﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace restaurant
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Homepage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
