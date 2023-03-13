using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class JohnnyTran : Driver
    {
        public JohnnyTran(RaceCar car) : base(car)
        {
            Name = "Johnny Tran";
            SkillLevel = 11;
        }
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
