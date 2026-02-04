namespace MethodsReturnkeywordMethodOverloadingParamskeywordExceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked"
            //          benefit = Let's reuse code w/o writing it multiple times

            String name = "Bro";
            int age = 25;
            // arguments = what is sent to methods

            singHappyBday(name, age);
            singHappyBday(name, age);
            singHappyBday(name, age);

            // return = returns data back to the place where a method is invoked
            double x;
            double y;
            const double z = 3.14; 
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Muliply(x, y);
            Console.WriteLine(result);

            // method overloading = methods share name, but different parameters
            //                      name + parameter + signature
            //                      methods must have a unique signature


            Console.WriteLine(Muliply(x,y,z));

            Console.ReadKey();
        }

        static double Muliply(double x, double y, double z)
        {
            return z * x * y;
        }
        static double Muliply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        static void singHappyBday(String birthdayBoy, int yearOld)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear "+birthdayBoy+"!");
            Console.WriteLine("You are going to turn "+ (yearOld + 1));
            Console.WriteLine("CONGRATULATIONS");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}