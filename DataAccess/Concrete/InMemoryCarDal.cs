using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car(){Id=1,BrandId=1,ColorId=1,ModelYear="2016",DailyPrice=1360,Description="Porsche 718 Boxster"},
                new Car(){Id=2,BrandId=1,ColorId=2,ModelYear="2007",DailyPrice=1200,Description="Porsche 911 Turbo"},
                new Car(){Id=3,BrandId=1,ColorId=3,ModelYear="2014",DailyPrice=2575,Description="Porsche 911 Carrera 4S"},
                new Car(){Id=4,BrandId=2,ColorId=4,ModelYear="2012",DailyPrice=8950,Description="Toyota"},
                new Car(){Id=5,BrandId=3,ColorId=5,ModelYear="2020",DailyPrice=2600,Description="Ford"}
            };
        }

        public void AddCar(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _car.SingleOrDefault(predicate => predicate.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public Car GetCarById(int id)
        {
            return _car.SingleOrDefault(predicate => predicate.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(predicate => predicate.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
