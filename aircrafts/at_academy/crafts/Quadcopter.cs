using at_academy.interfaces;
using System;

namespace at_academy.crafts
{
    public class Quadcopter : BaseAircraft, IRechargeable
    {
        private double batteryCapacity; // ( mAh )

        public Quadcopter(string _name) : base(_name)
        {
            AvgSpeed = 7f;
            Weight = 1.3f;
            MaxDistance = 7f;
            MaxTakeOffWeight = 1.3f;
            batteryCapacity = System.Math.Round(GetRandomNumber(1, 3830), 1);
        }

        public override void isCreated()
        {
            Console.WriteLine("Quadcopter " + '"' + Name + '"' + " is created successfully");
            Console.WriteLine("Current battery capacity is " + batteryCapacity + " mAh.");
        }

        public override void loadCargo(float _cargo)
        {
            Console.WriteLine("Quadcopter cannot carry things around. What a pity!");
        }

        public override void fly(double _distance)
        {
            if (_distance > MaxDistance)
            {
                Console.WriteLine("Sorry, distance is too big. Your quadcopter model cannot fly this far.");
            }
            else if (AvgSpeed * batteryCapacity / 3830 < _distance)
            {
                Console.WriteLine("Cannot start the flight. Charging is required.");
                charge();
            }
            else
            {
                Console.WriteLine("Flight has been safely finished!! (" + _distance + " km)");
                batteryCapacity -= System.Math.Round(_distance / AvgSpeed * 3830, 1);
                Console.WriteLine("Remaining battery capacity is " + batteryCapacity);
            }

        }

        public void charge()
        {
            batteryCapacity = 3830f;
            Console.WriteLine("Your " + Name + " is fully charged and ready to go!");
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
