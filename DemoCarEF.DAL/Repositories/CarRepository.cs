using DemoCarEF.DAL.Entities;

namespace DemoCarEF.DAL.Repositories
{
	public class CarRepository
	{
        private DemoCarContext Context { get; init; }

		public CarRepository(DemoCarContext context)
		{
			this.Context = context;
		}

		public List<Car> GetAll()
		{
			return Context.Cars.ToList();
		}

		public void Create(Car car)
		{
			Context.Cars.Add(car);
			Context.SaveChanges();
		}

		public void Delete(Car car)
		{
			if (car is null || GetOneById(car.Id) is null)
			{
				throw new Exception("Car not found!");
			}
			Context.Cars.Remove(car);
			Context.SaveChanges();
		}

		public Car? GetOneById(int id)
		{
			return Context.Cars.FirstOrDefault(car => car.Id == id);
		}

		public void Update(Car car)
		{
			if (car is null)
			{
				throw new Exception("Invalid car");
			}
			Car? CarToUpdate = this.GetOneById(car.Id);
			if (CarToUpdate is null)
			{
				throw new Exception("Car not found!");
			}

			Context.Cars.Update(car);
			Context.SaveChanges();
		}
	}
}
