using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.ViewModels
{
	public class CarListViewModel
	{
		public IEnumerable<Car> allCars { get; set; }
		public string currCategory { get; set; }
	}
}
