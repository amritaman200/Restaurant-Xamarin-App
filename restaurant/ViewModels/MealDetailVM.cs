using restaurant.Models;
using restaurant.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace restaurant.ViewModels
{
	public class MealDetailVM : BindableObject, INotifyPropertyChanged
	{
		private bool _isLoading;
		private readonly MealDetailService _mealDetailService;
		private ObservableCollection<Recipe> _items;

		public ObservableCollection<Recipe> Items
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

		public MealDetailVM(string mealId)
		{
			_mealDetailService = new MealDetailService();
			LoadItemsAsync(mealId);
		}

		private async Task LoadItemsAsync(string mealId)
		{
			IsLoading = true;
			await Task.Delay(1000);
			var items = await _mealDetailService.GetItemsAsync("https://www.themealdb.com/api/json/v1/1/lookup.php?i="+mealId);
			if (items != null)
			{
				Items = new ObservableCollection<Recipe>(items.meals);
			}
			else
			{
				// Handle the case when items are null (e.g., show an error message)
			}
			IsLoading = false;
		}

		
	}
}
