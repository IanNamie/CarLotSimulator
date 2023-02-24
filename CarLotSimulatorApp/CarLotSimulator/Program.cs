using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var honda = new Car();
            honda.IsDriveAble = true;
            honda.Year = 2017;
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.EngineNoise = "vrrrrrrrr";
            honda.HonkNoise = "meep meep";
            lot.Cars.Add(honda);

            var tesla = new Car() 
            {
                Make = "Tesla", 
                Model = "Model S", 
                Year = 2022, 
                EngineNoise = "Silent", 
                HonkNoise = "Beep Beep!!!", 
                IsDriveAble = true
            };
            lot.Cars.Add(tesla);

 var mazda = new Car(2019, "Mazda", "Cx 5", "MMMMmmmmmmmerrrrrrrrrrrrrRRRRRRRRRRRRRmrrrrrrrrrrr", "MEEP!! MEEP!!", true);
            lot.Cars.Add(mazda);

            foreach (var car in lot.Cars)
            { 
                Console.WriteLine($"Year: {car.Year}, Make:{car.Make}, Model: {car.Model}"); 
            }
            Console.WriteLine("----------------------------------");


            Console.WriteLine(honda.Make);
            /*Console.WriteLine(honda.Model);
            Console.WriteLine(honda.Year);
            Console.WriteLine($"{honda.IsDriveAble} the vehicle is driveable.");*/
            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);
            Console.WriteLine("----------------------------------");

            Console.WriteLine(tesla.Make);
            /*Console.WriteLine(tesla.Model);
            Console.WriteLine(tesla.Year);
            Console.WriteLine($"{tesla.IsDriveAble} the vehicle is driveable.");*/
            tesla.MakeEngineNoise(tesla.EngineNoise);
            tesla.MakeHonkNoise(tesla.HonkNoise);
            Console.WriteLine("----------------------------------");

            Console.WriteLine(mazda.Make);
            /*Console.WriteLine(mazda.Model);
            Console.WriteLine(mazda.Year);
            Console.WriteLine($"{mazda.IsDriveAble} the vehicle is driveable.");*/
            mazda.MakeEngineNoise(mazda.EngineNoise);
            mazda.MakeHonkNoise(mazda.HonkNoise);
            Console.WriteLine("----------------------------------");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
