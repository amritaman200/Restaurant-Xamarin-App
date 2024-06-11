using restaurant.Models;
using restaurant.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace restaurant.ViewModels
{
	public class MealsVM : BindableObject
	{
		private bool _isLoading;
    
		private readonly MealService _mealService;
		private ObservableCollection<Meal> _items;

		public ObservableCollection<Meal> Items
		{
			get => _items;
			set
			{
				_items = value;
				OnPropertyChanged();
			}
		}
		public bool IsLoading
		{
			get => _isLoading;
			set
			{
				_isLoading = value;
				OnPropertyChanged();
			}
		}

		public MealsVM()
		{
			_mealService = new MealService();
			LoadItemsAsync();
		}

		private async Task LoadItemsAsync()
		{
			IsLoading = true;
			await Task.Delay(1000);
			var items = await _mealService.GetItemsAsync("https://www.themealdb.com/api/json/v1/1/filter.php?c=Seafood");
			if (items != null)
			{
				Items = new ObservableCollection<Meal>(items);
			}
			else
			{
				// Handle the case when items are null (e.g., show an error message)
			}
			IsLoading = false;
		}

		
	}
}
