using System;


namespace at_academy.crafts
{
    public class Balloon : BaseAircraft
    {
        public Balloon(string _name) : base(_name)
        {
            AvgSpeed = 300f;
            Weight = 300;
            MaxCargoCapacity = 100f;
            MaxPassengersCapacity = 15;
            MaxTakeOffWeight = 800f;
            MaxDistance = 2500f;
            FuelCapacity = 150f;
        }

        override public void isCreated()
        {
            Console.WriteLine("Balloon " + '"' + Name + '"' + " is created successfully");
        }
    }
}
