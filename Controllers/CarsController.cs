using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
	public class CarsController : Controller
	{
		private readonly IAllCars _allCars;
		private readonly ICarsCategory _allCategories;

		public CarsController(IAllCars allCars, ICarsCategory allCategories)
		{
			_allCars = allCars;
			_allCategories = allCategories;
		}
		[Route("Cars/List")]
		[Route("Cars/List/{category}")]
		public ViewResult List(string category)
		{
			IEnumerable<Car> cars;
			string curCategory = null;
			if (string.IsNullOrEmpty(category))
				cars = _allCars.Cars.OrderBy(p => p.id);
			else if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
			{
				cars = _allCars.Cars.Where(p => p.Category.categoryName.Equals("Электромобили")).OrderBy(p => p.id);
				curCategory = "Электромобили";
			}
			else
			{
				cars = _allCars.Cars.Where(p => p.Category.categoryName.Equals("Классические автомобили")).OrderBy(p => p.id);
				curCategory = "Электромобили";
			}
			ViewBag.Title = "Страница автомобилей";
			var obj = new CarListViewModel
			{
				allCars = cars,
				currCategory = curCategory
			};
			return View(obj);
		}
	}
}
