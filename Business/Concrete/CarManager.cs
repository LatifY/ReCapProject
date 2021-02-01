using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carService;

		public CarManager(ICarDal carDal)
		{
			_carService = carDal;
		}

		public void Add(Car car)
		{
			_carService.Add(car);
		}

		public void Delete(Car car)
		{
			_carService.Delete(car);
		}

		public void Update(Car car)
		{
			_carService.Update(car);
		}

		public List<Car> GetAll()
		{
			return _carService.GetAll();
		}

		public Car GetById(int CarId)
		{
			return _carService.GetById(CarId);
		}

	}
}
