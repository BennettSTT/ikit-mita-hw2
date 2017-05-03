using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Enums;

namespace ikit_mita_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lada = new Car(Category.D, "Лада");
            Console.WriteLine($"Имя водителя: {lada.CarPassport.Owner.Name}");

            var driver = new Driver(DateTime.Today, "Вольдемар");
            driver.Categories.Add(Category.B);
            driver.Categories.Add(Category.C);

            try
            {
                lada.ChangeOwner(driver, "o777ooo"); // ошибка, несоответствие категорий
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            driver.Categories.Add(Category.D);

            try
            {
                lada.ChangeOwner(driver, "o777ooo");
                Console.WriteLine($"Номер машины: {driver.Car.CarNumber}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Номер не указан по причине отсутствия машины");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Имя водителя: {lada.CarPassport.Owner.Name}");
            Console.ReadKey();
        }
    }
}
