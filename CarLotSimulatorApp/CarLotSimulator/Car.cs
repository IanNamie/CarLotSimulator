using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{ //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
  //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    public class Car
    {


        public Car() { }
        public Car(int year, string make, string model, string enginenoise, string honknoise, bool canDrive)
        { 
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveAble = canDrive;
        }



        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveAble { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }
    }
}
