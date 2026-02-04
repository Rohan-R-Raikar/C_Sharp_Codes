namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

            //String[] cars = {"BMW","Mustang","Corvette"};
            //cars[0] = "Tesla";

            String[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // foreach loop = a simpler way to iterate over an array, but it's lesss flexible

            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
        }
    }
}