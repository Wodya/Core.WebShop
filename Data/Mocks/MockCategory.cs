using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
	public class MockCategory : ICarsCategory
	{
		IEnumerable<Category> ICarsCategory.AllCategories
		{
			get
			{
				return new List<Category>{
					new Category{categoryName = "Электромобили", desc = "Совренный вид транспорта" },
					new Category{categoryName = "Классические автомобили", desc = "Машины с ДВС" },
				};
			}
		}
	}
}
