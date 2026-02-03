namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);


            //for loop = repeats some code a FINITE amount of times

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("HaPpY NeW yEaR");

            // nested loops = loops inside of other loops Uses vary.
            //                Used a lot in sorting algorithms

            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i< rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(symbol+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}