using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void AddCar(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetCarById(int id);

    }
}
