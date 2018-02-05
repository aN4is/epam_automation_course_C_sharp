using System;


namespace at_academy.crafts
{
    public class Helicopter : BaseAircraft
    {
        public Helicopter(string _name) : base(_name)
        {
            AvgSpeed = 430f;
            Weight = 2025f;
            MaxCargoCapacity = 20000f;
            MaxPassengersCapacity = 6;
            MaxTakeOffWeight = 3700f;
            MaxDistance = 1500f;
            FuelCapacity = 821f;
        }

        override public void IsCreated()
        {
            Console.WriteLine("Helicopter " + '"' + Name + '"' + " is created successfully");
        }
    }
}
