using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data
{
	public class AppDbContent : DbContext
	{
		public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
		{

		}
		public DbSet<Car> Car { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<ShopCartItem> ShopCartItem { get; set; }
	}
}
