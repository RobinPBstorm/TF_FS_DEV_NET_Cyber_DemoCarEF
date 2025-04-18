﻿using DemoCarEF.DAL;
using DemoCarEF.DAL.Entities;
using DemoCarEF.DAL.Repositories;

namespace DemoCarEF
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DemoCarContext context = new DemoCarContext();
			BrandRepository brandRepository = new BrandRepository(context);

			try
			{
				//brandRepository.Create(new Brand { Name = "Jeep", Origin = "USA" });

				//Brand brandASupprimer = brandRepository.GetOneById(2);
				//brandRepository.Delete(brandASupprimer);

				//Brand newBrand = new Brand { Name = "Peugeot", Origin = "France" };
				//brandRepository.Update(3, newBrand);

			}
			catch(Exception exception)
			{
				Console.WriteLine(exception.Message);
			}

				foreach (Brand brand in brandRepository.GetAll())
			{
				Console.WriteLine($"{brand}");
			}
		}
	}
}
