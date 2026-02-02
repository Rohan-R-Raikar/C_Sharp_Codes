namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * type casting = Converting a value to a different data type
             *                Useful when we accept user input (string)
             *                Different data types can do different things 
             */

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}