using DemoCarEF.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoCarEF.DAL
{
	public class DemoCarContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "Data Source=DESKTOP-HK4B100\\DATAVIZ;Initial Catalog=CarEF;Integrated Security=True;Trust Server Certificate=True";
			optionsBuilder.UseSqlServer(connectionString);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().HasOne(car => car.Brand).WithMany();
		}
	}
}
