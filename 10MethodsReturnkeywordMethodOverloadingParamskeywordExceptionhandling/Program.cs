using System.ComponentModel.Design;

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
            double x = 10;
            double y = 10;
            const double z = 3.14; 
            double result;

            result = Muliply(x, y);
            Console.WriteLine(result);

            // method overloading = methods share name, but different parameters
            //                      name + parameter + signature
            //                      methods must have a unique signature


            Console.WriteLine(Muliply(x,y,z));

            // params keyword = a method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(total);

            Console.ReadKey();

            /*
             *  try = try some code that is considered "dangerous"
             *  catch = catches and handles exceptions when they occur
             *  finally = always executes regardless if exception is caught or not
             */
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
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