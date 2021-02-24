using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        { 
            CarManager carManager = new CarManager(new EfCarDal());
            

           readBefore(carManager);

           // Car car = addOpeasyonu(carManager);

           // updateOperasyonu(carManager, car);

           // deleteOperasyonu(carManager, car);

           // brandaGore(carManager);

           // coloraGore(carManager);


        }

        private static void coloraGore(CarManager carManager)
        {
            foreach (var c in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(c.ColorId + " " + c.Description);
            }

            Console.WriteLine("-----------------------------------------------");
        }

        private static void brandaGore(CarManager carManager)
        {
            Console.WriteLine("-----------------------------------------------");

            foreach (var c in carManager.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine(c.BrandId + " " + c.Description);
            }

            Console.WriteLine("-----------------------------------------------");
        }

        private static void deleteOperasyonu(CarManager carManager, Car car)
        {
            carManager.Delete(car);
            Console.WriteLine("Silme işleminden sonra:");
            Console.WriteLine("-----------------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Description + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
        }

        private static void updateOperasyonu(CarManager carManager, Car car)
        {
            car.DailyPrice = 100;
            carManager.Update(car);
            Console.WriteLine("İşlemi güncelledikten sonra: ");
            Console.WriteLine("-----------------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Description + " Günlük Fiyat: " + c.DailyPrice + "$");
            }
        }

        private static Car addOpeasyonu(CarManager carManager)
        {
            Car car = new Car { BrandId = 3, ColorId = 1, DailyPrice = 120, Description = "Porsche", ModelYear = 2021 };
            carManager.Add(car);
            Console.WriteLine("İşlem ekledikten sonra: ");
            Console.WriteLine("-----------------------------------------------");
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Id + " " + c.Description + " Günlük Fiyat: " + c.DailyPrice + "$");
            }

            return car;
        }

        private static void readBefore(CarManager carManager)
        {
            Console.WriteLine("Öncesinde: ");
            Console.WriteLine("-----------------------------------------------");
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Id + " " + c.Description + " Günlük Fiyat: " + c.DailyPrice + "$");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

            
        }


    }
}

