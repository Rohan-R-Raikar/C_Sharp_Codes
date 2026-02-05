namespace ConditionaloperatorStringinterpolationMultiDimentionalarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false
            // (condition) ? x : y

            double temperature = 10;
            String message;

            message = (temperature >= 15) ? "Its worm outside" : "Its cold outside";

            Console.WriteLine(message);


            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Bro";
            String lastName = "Code";
            int age = 26;

            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"You are {age, -10} old.");

            String[] ford = {"Mustang", "F-150", "Explorer"};
            String[] chevy = {"Corvette", "Camaro", "Silverado"};
            String[] toyota = {"Corolla", "Camry", "Rav4"};

            String[,] parkingLot = { 
                { "Mustang", "F-150", "Explorer" },
                {"Corvette", "Camaro", "Silverado"},
                {"Corolla", "Camry", "Rav4"}
            };

            Console.ReadKey();
        }
    }
}