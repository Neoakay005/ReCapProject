using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=3, ModelYear="2010", DailyPrice=65000, Description="Kazalı" },
                new Car{Id=2, BrandId=2, ColorId=6, ModelYear="2008", DailyPrice=54200, Description="Ağır Kazalı" },
                new Car{Id=3, BrandId=3, ColorId=2, ModelYear="2015", DailyPrice=105000, Description="Kazasız" },
                new Car{Id=4, BrandId=2, ColorId=1, ModelYear="2013", DailyPrice=72000, Description="Kazasız" },
                new Car{Id=5, BrandId=2, ColorId=3, ModelYear="2020", DailyPrice=150000, Description="Kazasız, acil satılık" },
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car itemsToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(itemsToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car itemsToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            itemsToUpdate.Id = car.Id;
            itemsToUpdate.BrandId = car.BrandId;
            itemsToUpdate.ColorId = car.ColorId;
            itemsToUpdate.ModelYear = car.ModelYear;
            itemsToUpdate.DailyPrice = car.DailyPrice;
            itemsToUpdate.Description = car.Description;
        }
    }
}
