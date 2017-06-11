using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassport
    {
        public CarPassport(Car car)
        {
            Car = car;
        }
        public Driver Owner = new Driver(DateTime.Today, "Какой-то водитель");
        public Car Car { get; }
    }
}
