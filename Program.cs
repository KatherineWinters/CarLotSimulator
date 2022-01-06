using System;

namespace CarLotSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            Car honda = new Car();
            {
                honda.Year = 2010;
                honda.Make = "Honda";
                honda.Model = "Odyssey";
                honda.EngineNoise = "vroom";
                honda.HonkNoise = "beep beep";
                honda.IsDrivable = true;
            }

            lot.Cars.Add(honda);

            Console.WriteLine($"Year: {honda.Year}");
            Console.WriteLine($"Make: {honda.Make}");
            Console.WriteLine($"Model: {honda.Model}");
            Console.WriteLine($"Engine noise: {honda.EngineNoise}");
            Console.WriteLine($"Is it drivable: {honda.IsDrivable}");
            Console.WriteLine();

            Car jeep = new Car();
            {
                jeep.Year = 2017;
                jeep.Make = "Jeep";
                jeep.Model = "Renegade";
                jeep.EngineNoise = "vrooooom";
                jeep.HonkNoise = "beep";
                jeep.IsDrivable = false;
            }

            lot.Cars.Add(jeep);

            Console.WriteLine($"Year: {jeep.Year}");
            Console.WriteLine($"Make: {jeep.Make}");
            Console.WriteLine($"Model: {jeep.Model}");
            Console.WriteLine($"Engine noise: {jeep.EngineNoise}");
            Console.WriteLine($"Is it drivable: {jeep.IsDrivable}");
            Console.WriteLine();

            Car hyundai = new Car();
            {
                hyundai.Year = 2013;
                hyundai.Make = "Hyundai";
                hyundai.Model = "Elantra";
                hyundai.EngineNoise = "click click click";
                hyundai.HonkNoise = "squeak";
                hyundai.IsDrivable = false;
            }

            lot.Cars.Add(hyundai);

            Console.WriteLine($"Year: {hyundai.Year}");
            Console.WriteLine($"Make: {hyundai.Make}");
            Console.WriteLine($"Model: {hyundai.Model}");
            Console.WriteLine($"Engine noise: {hyundai.EngineNoise}");
            Console.WriteLine($"Is it drivable: {hyundai.IsDrivable}");

            Console.WriteLine($"Number of cars made: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
