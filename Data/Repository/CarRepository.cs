using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Repository
{
	public class CarRepository : IAllCars
	{
		private readonly AppDbContent appDbContent;
		public CarRepository(AppDbContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}
		public IEnumerable<Car> Cars => appDbContent.Car.Include(p => p.Category);
		public IEnumerable<Car> getFavCars => appDbContent.Car.Where(p => p.isFavourite).Include(p => p.Category);
		public Car getObjectCar(int carId) => appDbContent.Car.FirstOrDefault(p => p.id == carId);
	}
}
