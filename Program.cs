namespace InterfaceBilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cykelskoj
            Bicycle bmx = new Bicycle();
            bmx.applyBrakes();
            bmx.changeGear(3);
            bmx.speedUp(99);
            Console.WriteLine("Bike present state " + " Gear: " + bmx.Gear + " and " + bmx.Speed + " km/h");

            //motorcykel
            Bike mc = new Bike();

            mc.applyBrakes();
            mc.changeGear(1);
            //Console.WriteLine(mc.Gear);
            mc.speedUp(60);
            Console.WriteLine("Bike present state " + " Gear: " +  mc.Gear + " and " + mc.Speed + " km/h");

        }

        interface IVehicle
        {
            void changeGear(int a);
            void speedUp(int a);
            void applyBrakes();
        }

        class Bicycle : IVehicle
        {
            public int Gear { get; set; }
            public int Speed { get; set; }
            public void applyBrakes()
            {
                Console.WriteLine("Squueeeeeeeeeeeeeeeeeeeeeeeeeeeeeek");
            }

            public void changeGear(int a)
            {
                Console.WriteLine("Current gear is " + a);
                Gear = a;
            }

            public void speedUp(int a)
            {
                Console.WriteLine("Currenty at " + a + "%");
                Speed = a;
            }
        }
        class Bike : IVehicle
        {
            public int Gear { get; set; }
            public int Speed { get; set; }
            public void applyBrakes()
            {
                Console.WriteLine("Mc slows down..    moorw..");
            }

            public void changeGear(int a)
            {
                Console.WriteLine("Current gear is " + a);
                Gear = a;
            }

            public void speedUp(int a)
            {
                Console.WriteLine("Currenty at " + a + "km/h");
                Speed = a;
            }

        }



    }
}