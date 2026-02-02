namespace Varibales
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x= 123;//initialization

            int y = 321;
            int z = x + y;
            int age = 25;
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            String name = "Bro";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your Age is: " + age);
            Console.WriteLine("Your Height is: " + height+"cm");
            Console.WriteLine("Are you alive: " + alive);
            Console.WriteLine("Your Symbol: " + symbol);

            String userName = symbol + name; ;
            Console.WriteLine("Your User Name is: " + userName);


            /*
             * constants = immutable values which are known at compile time
             *              and do not change for the life of the program
             */

            const double pi = 3.14159;

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}