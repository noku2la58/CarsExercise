using System;

namespace CarsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2003, "Jazz", 0);
            myCar.Colour = "Red";
            myCar.DriveFaster(20);
           
            Car angelsCar = new Car(2022, "Porsche", 0);
            angelsCar.Colour = "Pink";
            angelsCar.DriveFaster(120);

            Console.WriteLine("Allans Jazz car: " + myCar.Speed);
            Console.WriteLine("Angels Pink car: " + angelsCar.Speed);
           
            /*
            
            Car vw = new Car(2020, "Polo", 10);
            vw.DriveFaster(45);
            vw.Make = "Golf";

            Car bmw = new Car(2019, "M3", 0);

            Car rollsRoyce = new Car(2019, "Phantom", 0);

            Car mazda = new Car(1989, "323", 0);

            Car toyota = new Car(1973, "Cresida", 0);

            */
        }
    }
}
