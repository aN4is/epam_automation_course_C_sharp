using at_academy.crafts;
using System;


namespace at_academy.singleton
{ 
    public class SecretShip : BaseAircraft
    {
        private static SecretShip instance;

        private SecretShip(string _name) : base(_name)
        {
        }

        public override void IsCreated()
        {
             Console.WriteLine("Unique Secret Ship '{0}' is created successfully. Do not try to create another one", Name);
        }       

        public static SecretShip Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SecretShip("Optimus Prime");
                }

                return instance;
            }
           
        }

    }
}
