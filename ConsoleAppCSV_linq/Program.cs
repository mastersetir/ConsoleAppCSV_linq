using ConsoleAppCSV_linq.Cars;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleAppCSV_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSV (comma-separated values)  linq");
            var query = ProcessFile("cars.csv");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
        }


      private  static List<Car?> ProcessFile(string path)
        {
           return  System.IO.File.ReadAllLines(path)
                            .Skip(1)
                            .Where(line => line.Length >1)
                            .Select(Car.ParseFromCSV)
                            .ToList();             
         /*  var query = from line in System.IO.File.ReadAllLines(path)
                        where line.ToString().Length > 1
                        select Car.ParseFromCSV(line);
           return query.ToList();
*/

        }
    }
}
