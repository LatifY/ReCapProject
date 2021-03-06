﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	//GetById, GetAll, Add, Update, Delete
	public interface ICarDal
	{
		Car GetById(int CarId);
		List<Car> GetAll();
		void Add(Car car);
		void Update(Car car);
		void Delete(Car car);
	}
}
