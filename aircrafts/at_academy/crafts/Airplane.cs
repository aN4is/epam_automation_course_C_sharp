using System;


namespace at_academy.crafts
{
    public class Airplane : BaseAircraft
    {
        public Airplane(string _name) : base(_name)
        {
            AvgSpeed = 900f; 
            Weight = 570000f; 
            MaxCargoCapacity = 154000f;
            MaxPassengersCapacity = 416;
            MaxTakeOffWeight = 160000f;
            MaxDistance = 13400f;            
            FuelCapacity = 183.380f;
        }

        override public void isCreated()
        {
            Console.WriteLine("Airplane " + '"' + Name + '"' + " is created successfully");
        }
    }
}
