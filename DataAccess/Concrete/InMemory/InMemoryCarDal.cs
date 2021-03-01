﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; // Global değişkenler "_" ile başlar. 

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,ColorId=3,BrandId=1,DailyPrice=500000,Description="Car Description",ModelYear=2020},
                new Car{Id=2,ColorId=1,BrandId=1,DailyPrice=700000,Description="Car Description",ModelYear=2020},
                new Car{Id=3,ColorId=1,BrandId=2,DailyPrice=50000,Description="Car Description",ModelYear=2018},
                new Car{Id=4,ColorId=4,BrandId=3,DailyPrice=100000,Description="Car Description",ModelYear=2019},
                new Car{Id=5,ColorId=2,BrandId=3,DailyPrice=2000000,Description="Car Description",ModelYear=20210}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id== id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
