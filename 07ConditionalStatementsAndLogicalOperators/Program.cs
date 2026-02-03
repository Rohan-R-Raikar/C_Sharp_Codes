namespace ConditionalStatementsAndLogicalOperators
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are Eligible");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are Minor");
            }
            else
            {
                Console.WriteLine("You are exactly 18 years old.");
            }

            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You haven't Entered your Name");
            }
            else
            {
                Console.WriteLine("Hi there " + name);
            }

            //switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Wensday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Monday!");
                    break;
                default:
                    Console.WriteLine(day + "It's not any day at all!");
                    break;
            }

            // logical operators = Can be used to check if more than I condition is true/false

            // && (AND)
            // || (OR)

            Console.WriteLine("What's the temprature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }

            Console.ReadKey();

        }
    }
}