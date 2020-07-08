using SoCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = DataRepository.Car.GetCount();
            Console.WriteLine(cars);

        }
    }
}
