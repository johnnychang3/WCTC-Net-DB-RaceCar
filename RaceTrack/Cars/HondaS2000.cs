using RaceTrack.RaceTrack.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class HondaS2000 : RaceCar
    {
        public HondaS2000() 
        {
            Name = "Honda S2000";
            TopSpeed = 120;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} comes to a stop and end in position {Position}");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine turns off.");
        }
    }
}
