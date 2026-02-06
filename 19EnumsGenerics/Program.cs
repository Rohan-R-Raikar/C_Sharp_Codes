namespace EnumsGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // enums = special "class" that contains a set of named integer constants.
            //         Use enums when you have values that you know will not change,
            //         To get the integer value from an item, you an item, you must explicitly convert to an int

            // name = integer

            Console.WriteLine(Cars.Honda + " is a Car @"+(int)Cars.Honda);

            // generic = "not specific to a particular data type"
            //           add <T> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3"};

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing i in array)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
    enum Cars
    {
        BMW,
        MWB,
        WMB,
        Maruti,
        Suzuki,
        Honda,
        Kia,
        Tata,
        Yezdi
    }
}