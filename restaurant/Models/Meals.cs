using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant.Models
{
	public class Meal
	{
		public string strMeal { get; set; }
		public string strMealThumb { get; set; }
		public string idMeal { get; set; }
	}

	public class Meals
	{
		public List<Meal> meals { get; set; }
	}
}
