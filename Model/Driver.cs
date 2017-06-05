using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public DateTime LicenceDate { get; }
        public string Name { get; }
        public TimeSpan Experience => DateTime.Now - LicenceDate;

        private List<Category> _categories;
        public List<Category> Categories
        {
            get => _categories ?? (_categories = new List<Category>());
            set => _categories = value;
        }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Categories.Any(category => category == car.Category))
            {
                Car = car;
            }
            else
            {
                throw new Exception("Не соответствуют категории, присваивание НЕ БУДЕТ ПРОИЗВЕДЕНО");
            }
        }
    }
}
