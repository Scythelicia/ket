using System;
using System.Drawing;

namespace Activity2 {

    public class Car {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Price {get; set;}

        public void Honk(string stringVariable) { 
        Console.WriteLine($"{stringVariable}: Honk!!!");
        }

    
    }
    class Program {
        static void Main(string[]args) {
            List<Car> list = new List<Car>();
            while (true) 
            {
                Console.Write("Enter new data? [Y/N]");

                if (Console.ReadLine() == "N") 
                {
                    break;
                }

                Car car1 = new Car();

                Console.Write("Enter Car Brand>>");
                car1.Brand = Console.ReadLine();

                Console.Write("Enter Car Color>>");
                car1.Color = Console.ReadLine();

                Console.Write("Enter Car Price>>");
                car1.Price = Console.ReadLine();

                list.Add(car1);
            }
            list.ForEach(x =>
            {
                Console.WriteLine("The car brand is = " + x.Brand);
                Console.WriteLine("The car is color = " + x.Color);
                Console.WriteLine("The Price = " + x.Price);
                Console.WriteLine("=====================");
            });

        
        }
    
    }
}