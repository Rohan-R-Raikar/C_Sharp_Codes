namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding = provides a new version of a method inherited from a parent class
            //                     inherited method must be abstract,virtual,or already overriden
            //                     Used with ToString(), polymorphism

            // For abstract classes or methods

            Dog dog = new Dog();
            Cat cat = new Cat();


            // ToString() = converts an object to its string representation so that it is suitable
            //              for display

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The Animal Goes *brrrrrrrrrrrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bhau Bhau");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Mau Mau");
        }
    }
}