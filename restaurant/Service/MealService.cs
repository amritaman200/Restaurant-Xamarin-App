using Newtonsoft.Json;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Service
{
	public class MealService
	{
		private readonly HttpClient _httpClient;

		public MealService()
		{
			_httpClient = new HttpClient();
		}

		public async Task<List<Meal>> GetItemsAsync(string url)
		{
			var response = await _httpClient.GetAsync(url);

			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				var item = JsonConvert.DeserializeObject<Meals>(json);
				List<Meal> meals = new List<Meal>(item.meals);
				return meals;
			}
			else
			{
				return null;
			}
		}
	}
}
