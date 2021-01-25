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
	public class ShopCartController : Controller
	{
		private readonly IAllCars _carRep;
		private readonly ShopCart _shopCart;

		public ShopCartController(IAllCars carRep, ShopCart shopCart)
		{
			_carRep = carRep;
			_shopCart = shopCart;
		}
		public ViewResult Index()
		{
			var items = _shopCart.getShopItems();
			_shopCart.listShopItems = items;

			var obj = new ShopCartViewModel { shopCart = _shopCart };
			return View(obj);
		}
		public RedirectToActionResult AddToCart(int id)
		{
			var item = _carRep.Cars.FirstOrDefault(p => p.id == id);
			if (item != null)
			{
				_shopCart.AddToCart(item);
			}
			return RedirectToAction("Index");
		}
	}
}
