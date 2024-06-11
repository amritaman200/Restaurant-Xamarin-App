using Newtonsoft.Json;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Service
{
	public class CategoriesService
	{
		private readonly HttpClient _httpClient;

		public CategoriesService()
		{
			_httpClient = new HttpClient();
		}

		public async Task<Categories> GetItemsAsync(string url)
		{
			var response = await _httpClient.GetAsync(url);

			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				var item = JsonConvert.DeserializeObject<Categories>(json);
				return item;
			}
			else
			{
				return null;
			}
		}
	}
}

