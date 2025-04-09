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

			//Brand Jeep = new Brand { Id = 1, Name = "Jeep", Origin = "USA" };
			//Brand Peugeot = new Brand { Id = 2, Name = "Peugeot", Origin = "France" };
			
			//modelBuilder.Entity<Brand>().HasData([
			//	Jeep,
			//	Peugeot
			//]);
			//modelBuilder.Entity<Car>().HasData([
			//	new Car { Id = 1, Model = "Wrangler", Brand = Jeep },
			//	new Car { Id = 2, Model = "Cherokee", Brand = Jeep },
			//	new Car { Id = 3, Model = "3008", Brand = Peugeot },
			//	new Car { Id = 4, Model = "508", Brand = Peugeot }
			//]);

		}
	}
}
