using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void AddCar(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetCarById(int id);
    }
}
