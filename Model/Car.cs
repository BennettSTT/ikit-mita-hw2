using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Car
    {
        public Car(Category category, string model) // Category????
        {
            if (category != Category.A) // ??????????
                Category = category;

            Model = model;
            CarPassport = new CarPassport(this);
        }

        public readonly string Model; // Имя водителя или модель машины? Имя водителя 
                                      // можно вывести через CarPassport
        public readonly Category Category;
        public readonly CarPassport CarPassport;

        public Color Color = Color.Blue;
        public string CarNumber { get; private set; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carNumber;
        }
    }
}
