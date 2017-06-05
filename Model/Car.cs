using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(Category category, string model)
        {
            if (category == Category.A)
            {
                throw new Exception("Неверная категория");
            }
            Category = category;
            Model = model;
            CarPassport = new CarPassport(this);
        }
        public Category Category { get; }
        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carNumber;
        }
    }
}
