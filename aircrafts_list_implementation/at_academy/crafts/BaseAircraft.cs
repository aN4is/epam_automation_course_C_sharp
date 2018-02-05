using System;

namespace at_academy.crafts
{
    public abstract class BaseAircraft
    {
        public string Name { get; set; }
        public float AvgSpeed { get; set; } // average speed of an aircraft ( km/h )
        public float Weight { get; set; } // weight of an aircraft ( kg )
        public float MaxCargoCapacity { get; set; } // how much an aircraft can carry ( kg )
        public int MaxPassengersCapacity { get; set; } // how many persons an aircraft can carry
        public float MaxTakeOffWeight { get; set; } // (kg)
        public double MaxDistance { get; set; } // max flight distance of an aircraft ( km )
        public float FuelCapacity { get; set; } // ( liters )

        public double Price { get; set; }

        public BaseAircraft(string _name)
        {
            Name = _name;
        }

        public abstract void IsCreated();

        public void PrintInfo<T>()
        {
            Console.WriteLine("This is a value of type {0}", typeof(T));
        }



        // the following method calculates Maximum Take-Off Weight (MTOW) of an aircraft with average weight per person equals 80 kg
        public float CalculateMTOW()
        {
           return MaxCargoCapacity + (float)MaxPassengersCapacity * 80;
        }


        public virtual void Fly(double _distance) // (km)
        {
            if (AvgSpeed * FuelCapacity / _distance > MaxDistance)
            {
                Console.WriteLine("Not enough fuel in gas tank. Need refill.");
            }
            else
            {
                Console.WriteLine("Flight has been safely finished!! (" + _distance + " km)");
            }

        }

        public virtual void LoadCargo(float _cargo)
        {
            if (_cargo > MaxCargoCapacity)
            {
                Console.WriteLine("Cargo capacity for " + Name + " was exceeded. Cargo was not loaded.");
            }
            else
            {
                Console.WriteLine("{0} kg of cargo was loaded successfully! ({1})", _cargo, Name.ToUpper());
            }
        }


        public void LoadPassengers(int passengersCount)
        {
            if (passengersCount > MaxPassengersCapacity)
            {
                Console.WriteLine("Passengers limit for " + Name + " was exceeded. No passengers were boarded.");
            }
            else
            {
                Console.WriteLine("{0} passengers were boarded on {1} successfully!!", passengersCount, Name);
            }
        }

        public void TakeOff()
        {
            if (CalculateMTOW() > MaxTakeOffWeight || CalculateMTOW() == 0)
            {
                Console.WriteLine("Unfortunately, " + Name + " did not succeed to take off.");
            }
            else
            {
                Console.WriteLine("Congrats! " + Name + " took off successfully!!");
            }
        }
    }
}
