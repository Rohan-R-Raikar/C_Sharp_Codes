namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Hello " + name);

            double friends = 5;

            friends = friends + 2;
            friends += 2;
            friends++;
            Console.WriteLine(friends);
            friends = friends - 2;
            friends -= 2;
            friends--;
            Console.WriteLine(friends);
            friends = friends * 2;
            friends *= 2;
            Console.WriteLine(friends);
            friends = friends / 2;
            friends /= 2;
            Console.WriteLine(friends);
            friends = friends % 2;
            friends %= 2;
            Console.WriteLine(friends);

            double x = 3.99;
            double y = 5;

            double a = Math.Pow(x, 3);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}