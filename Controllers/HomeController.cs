using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
	public class HomeController : Controller
	{
		private readonly IAllCars _carRep;

		public HomeController(IAllCars carRep)
		{
			_carRep = carRep;
		}
		public ViewResult Contact()
		{
			ViewBag.Company = "Славная компания";
			ViewBag.Title = "Информация о компании";
			return View();
		}
		public ViewResult Index()
		{
			var homeCars = new HomeViewModel
			{
				favCars = _carRep.getFavCars
			};
			return View(homeCars);
		}
	}
}
