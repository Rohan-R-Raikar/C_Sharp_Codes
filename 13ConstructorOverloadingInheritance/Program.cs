namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza myPizza = new Pizza("Thin crust", "Tomato", "Mozzarella", "Pepperoni");
            Pizza myPizza2 = new Pizza("Thick crust", "Onion");

            // Inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            car.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            car.go();

            Console.ReadKey();
        }
    }

    class Vehicle
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
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String toppings;

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(string bread, string sauce, string cheese, string toppings)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
        }
    }
}
