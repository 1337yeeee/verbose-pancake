using System;
using Microsoft.EntityFrameworkCore;
using Vision.Storage;

namespace Vision.Data
{
	public class AppDBContent : DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{
		}

		//public DbSet<Clothes>
	}
}
