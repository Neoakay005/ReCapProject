using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("ID: {0}, Model Yılı:{1}",item.Id, item.ModelYear);
            }
        }
    }
}
