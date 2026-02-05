namespace ClassesObjectsConstructorStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            //         Can be used as a blueprint to create objects (OOP)

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
            Console.WriteLine();

            // object = An Instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          ojects can have fields & methods (characteristics & actions)

            Human human1 = new Human("Rick", 21);
            Human human2 = new Human("Morty", 22);

            //human1.name = "Rick";
            //human1.age = 21;
            //human1.Eat();
            //human1.Sleep();

            //human2.name = "Morty";
            //human2.age = 22;
            //human2.Eat();
            //human2.Sleep();

            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            //Console.WriteLine(car1.numberOfCars);
            //Console.WriteLine(car2.numberOfCars);
            Console.Write("Number of Cars are :");
            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            // For Sake of information we cant create a object from a static class

            // We Dont Do this
            //Math math1 = new Marth();
            //math1.Round();

            // We Do this
            //Math.Round();


            Console.ReadLine();
        }
    }

    class Car
    {
        String model;

        public static int numberOfCars; 
        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine();
            Console.WriteLine("The Race has Begin");
        }
    }

    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age) 
        {
            this.name = name;
            this.age = age;
            Eat();
            Sleep();
        }

        public void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }


    class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visit");
        }
    }
}