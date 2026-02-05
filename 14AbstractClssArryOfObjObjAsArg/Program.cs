namespace AbstractClssArryOfObjObjAsArg
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing component or incomplete implementation
            /*
             * Basically if we make a class a abstract class then what will hapen
             * we cannot create a object using that class itself its something like
             * driving a Vehicle which is actually not rendered in Game
             */
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //Vehicle vehicle = new Vehicle();

            // Class Array Object
            MotarCycle[] motarCycles = new MotarCycle[4];

            MotarCycle m1 = new MotarCycle("Yezdi");
            MotarCycle m2 = new MotarCycle("Java");
            MotarCycle m3 = new MotarCycle("Suzuki");
            MotarCycle m4 = new MotarCycle("Yamaha");

            MotarCycle[] garage = new MotarCycle[4];

            garage[0] = m1;
            garage[1] = m2;
            garage[2] = m3;
            garage[3] = m4;

            foreach (MotarCycle cycle in garage)
            {
                Console.WriteLine(cycle.model);
            }

            MotarCycle[] bikes = { 
                new MotarCycle("Hero"), 
                new MotarCycle("TVS"), 
                new MotarCycle("Honda"),
                new MotarCycle("BMW"),
                new MotarCycle("RE"),
            };

            foreach(MotarCycle cycle in bikes)
            {
                Console.WriteLine(cycle.model);
            }

            Console.ReadKey();
        }
    }

    class MotarCycle
    {
        public String model;

        public MotarCycle(String model)
        {
            this.model = model;
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}