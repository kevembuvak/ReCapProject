using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using(CarDbContext context = new CarDbContext())
            {
                return filter == null
                    ? context.Cars.ToList()
                    : context.Cars.Where(filter).ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            using(CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice
                             };

                return result.ToList();
            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
