using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("г. Москва, проспект Маршала Жукова 31", 100, 20, 50);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding ("г. Санкт-Петербург, пабережная реки Мойки 28", 23, 15, 25, 3);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
