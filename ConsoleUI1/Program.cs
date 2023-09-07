using Business.Concrete;
using DataAccesss.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

CarManager carManager = new CarManager(new EfCarDal());

carManager.Add(new Car {ManufactureDate = DateTime.Now.AddDays(value: 3), Color = "Red",Brand  = "porche" , Price = 3000000 });

foreach (var car in carManager.GetAll().Data)
{
    Console.WriteLine(car.ManufactureDate);
}

