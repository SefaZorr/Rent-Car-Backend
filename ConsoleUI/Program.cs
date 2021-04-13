using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManagerEf = new CarManager(new EfCarDal());
            BrandManager brandManagerEf = new BrandManager(new EfBrandDal());
            ColorManager colorManagerEf = new ColorManager(new EfColorDal());
            UserManager userManagerEf = new UserManager(new EfUserDal());
            CustomerManager customerManagerEf = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManagerEf = new RentalManager(new EfRentalDal());

            AddEntries(carManagerEf, brandManagerEf, colorManagerEf, customerManagerEf, userManagerEf,rentalManagerEf);
            CarTest();
            //CustomerTest();

            //Console.WriteLine("Hello World!");
        }

        private static void AddEntries(CarManager carManagerEF, BrandManager brandManagerEF, ColorManager colorManagerEF, CustomerManager customerManagerEF, UserManager userManagerEF,RentalManager rentalManager)
        {
            //carManagerEF.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = "2002", Description = "Külüstür" });
            //carManagerEF.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = "1968", Description = "Retro" });
            //carManagerEF.Add(new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 250000, ModelYear = "1996", Description = "Aile" });
            //carManagerEF.Add(new Car { Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = "2012", Description = "Spor" });
            //carManagerEF.Add(new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 80000, ModelYear = "2008", Description = "Günlük" });
            //carManagerEF.Add(new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 130000, ModelYear = "2018", Description = "Fiyat-Performans" });
            //carManagerEF.Add(new Car { Id = 7, BrandId = 4, ColorId = 1, DailyPrice = 260000, ModelYear = "2015", Description = "Dağ" });
            //carManagerEF.Add(new Car { Id = 8, BrandId = 5, ColorId = 3, DailyPrice = 110000, ModelYear = "2005", Description = "Külüstür v2" });
            //carManagerEF.Add(new Car { Id = 9, BrandId = 2, ColorId = 4, DailyPrice = 275000, ModelYear = "2014", Description = "Hız" });

            //Console.WriteLine("Added Car Entries with EF...");


            //brandManagerEF.Add(new Brand { Id = 1, BrandName = "Tofaş" });
            //brandManagerEF.Add(new Brand { Id = 2, BrandName = "Ford" });
            //brandManagerEF.Add(new Brand { Id = 3, BrandName = "Volvo" });
            //brandManagerEF.Add(new Brand { Id = 4, BrandName = "Nissan" });
            //brandManagerEF.Add(new Brand { Id = 5, BrandName = "Volkswagen" });
            //brandManagerEF.Add(new Brand { Id = 6, BrandName = "Ferrari" });


            //Console.WriteLine("Added Brand Entries with EF...");

            //colorManagerEF.Add(new Color { Id = 1, ColorName = "Kırmızı" });
            //colorManagerEF.Add(new Color { Id = 2, ColorName = "Beyaz" });
            //colorManagerEF.Add(new Color { Id = 3, ColorName = "Siyah" });
            //colorManagerEF.Add(new Color { Id = 4, ColorName = "Mavi" });

            //Console.WriteLine("Added Color Entries with EF...");


            //userManagerEF.Add(new User { Id = 1, FirstName = "Berkcan", LastName = "Tezcaner", Email = "berkcantezcaner@gmail.com", Password = "123456" });
            //userManagerEF.Add(new User { Id = 2, FirstName = "Ayşe", LastName = "Demir", Email = "a.demir@mail.com", Password = "123456" });
            //userManagerEF.Add(new User { Id = 3, FirstName = "Ahmet", LastName = "Yılmaz", Email = "a.yilmaz@mail.com", Password = "123456" });
            //userManagerEF.Add(new User { Id = 4, FirstName = "John", LastName = "Carpenter", Email = "j.carpenter@mail.com", Password = "123456" });
            //userManagerEF.Add(new User { Id = 5, FirstName = "Alfred", LastName = "Hitchcock", Email = "a.hitchcock@mail.com", Password = "123456" });


            //Console.WriteLine("Added User Entries with EF...");

            //customerManagerEF.Add(new Customer { Id = 1, CompanyName = "A Firması", UserId = 1 });
            //customerManagerEF.Add(new Customer { Id = 2, CompanyName = "B Firması", UserId = 2 });
            //customerManagerEF.Add(new Customer { Id = 3, CompanyName = "C Firması", UserId = 3 });
            //customerManagerEF.Add(new Customer { Id = 4, CompanyName = "D Firması", UserId = 4 });

            //Console.WriteLine("Added Customer Entries with EF...");

            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021,03,30),ReturnDate=new DateTime(2021,04,30) });
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine("Customer Id:"+ customer.Id + " Company Name:" + customer.CompanyName + " User Id:" + customer.UserId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Melda", LastName = "Köse", Email = "meldakose99@gmail.com", Password = "123" });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAllColors().Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(colorManager.GetByColorId(1).Data);

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAllBrands().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetByBrandId(2).Data);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("CarName:"+car.CarName + "   CarBrand:" + car.BrandName + "   CarColor:" + car.ColorName + "   CarDailyPrice:" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
