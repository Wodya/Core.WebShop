using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Repository
{
	public class CategoryRepository : ICarsCategory
	{
		private readonly AppDbContent appDbContent;

		public CategoryRepository(AppDbContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}
		IEnumerable<Category> ICarsCategory.AllCategories => appDbContent.Category;
	}
}
