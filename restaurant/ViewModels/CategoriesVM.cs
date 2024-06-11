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
	public class CategoriesVM : BindableObject
	{
		private readonly CategoriesService _mealService;
		private ObservableCollection<Category> _items;

		public ObservableCollection<Category> Items
		{
			get => _items;
			set
			{
				_items = value;
				OnPropertyChanged();
			}
		}

		public CategoriesVM()
		{
			_mealService = new CategoriesService();
			LoadItemsAsync();
		}

		private async Task LoadItemsAsync()
		{
			var items = await _mealService.GetItemsAsync("https://www.themealdb.com/api/json/v1/1/categories.php");
			if (items != null)
			{
				Items = new ObservableCollection<Category>(items.categories);
			}
			else
			{
				// Handle the case when items are null (e.g., show an error message)
			}
		}


	}
}
