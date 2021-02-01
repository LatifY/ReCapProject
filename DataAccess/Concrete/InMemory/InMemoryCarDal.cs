using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;

		public InMemoryCarDal()
		{
			_cars = new List<Car>
			{
				new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2012, DailyPrice=30000, Description="Nice jeep Car" },
				new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2015, DailyPrice=35250, Description="Sedan" },
				new Car{CarId=3, BrandId=2, ColorId=5, ModelYear=2000, DailyPrice=10500, Description="Classical Car" },
				new Car{CarId=4, BrandId=2, ColorId=6, ModelYear=2020, DailyPrice=77000, Description="Modern super uber muber Car" },
				new Car{CarId=5, BrandId=3, ColorId=3, ModelYear=1990, DailyPrice=5000, Description="Old Car" },
				new Car{CarId=6, BrandId=3, ColorId=1, ModelYear=2013, DailyPrice=12000, Description="I have no idea wtf is this" },
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
			_cars.Remove(carToDelete);
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.ModelYear = car.ModelYear;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public Car GetById(int CarId)
		{
			return (Car)_cars.Where(c => c.CarId == CarId);
		}
	}
}
