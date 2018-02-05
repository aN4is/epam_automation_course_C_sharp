using System;


namespace at_academy.crafts
{
    public class Spaceship : BaseAircraft
    {
        public Spaceship(string _name) : base(_name)
        {
            AvgSpeed = 54000f;
            Weight = 80000f;
            MaxCargoCapacity = 200000f;
            MaxPassengersCapacity = 100;
            MaxTakeOffWeight = 200000f;
            MaxDistance = 54800000f;
            FuelCapacity = 500000f;
        }

        override public void IsCreated()
        {
            Console.WriteLine("Spaceship " + '"' + Name + '"' + " is created successfully");
        }
    }
}
