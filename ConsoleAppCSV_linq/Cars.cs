using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSV_linq.Cars
{
    public class Car
    {
        public int Year { get; set; }
        public string? Manufacturer { get; set; }
        public string? Name { get; set; }    
        public double Desplacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Higheay { get; set; }
        public int Combined { get; set; }

        public  static  Car? ParseFromCSV(string line)
        { 
            var car = line.Split(',');
            if (car.Length == 0)
                return null;
            else
                return  new Car {
                    Year = int.Parse(car[0]),
                    Manufacturer = car[1],
                    Name = car[2],
                    Desplacement = double.Parse(car[3]),
                    Cylinders = int.Parse(car[4]),
                    City = int.Parse(car[5]),
                    Higheay = int.Parse(car[6]),
                    Combined = int.Parse(car[7])
                };
        }




    } 

}
