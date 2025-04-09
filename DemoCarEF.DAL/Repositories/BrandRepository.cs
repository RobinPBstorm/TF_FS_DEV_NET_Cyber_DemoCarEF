using DemoCarEF.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoCarEF.DAL.Repositories
{
	public class BrandRepository
	{
		DemoCarContext context;

		public BrandRepository(DemoCarContext context)
		{
			this.context = context;
		}

		public List<Brand> GetAll()
		{
			return context.Brands.ToList();
		}

		public void Create(Brand brand)
		{
			context.Brands.Add(brand);
			context.SaveChanges();
		}

		public void Delete(Brand brand)
		{
			if (brand is null)
			{
				throw new Exception("Brand not found!");
			}
			context.Brands.Remove(brand);
			context.SaveChanges();
		}

		public Brand? GetOneById(int id)
		{
			return context.Brands.FirstOrDefault(brand => brand.Id == id);
		}

	}
}
