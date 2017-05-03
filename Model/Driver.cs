using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            _licenceDate = licenceDate;
            Name = name;
        }

        private readonly DateTime _licenceDate;
        public readonly string Name;
        private List<Category> _categories;

        public List<Category> Categories
        {
            get { return _categories ?? (_categories = new List<Category>()); }
            set { _categories = value; }
        }
        public TimeSpan Experience => DateTime.Now - _licenceDate;
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
