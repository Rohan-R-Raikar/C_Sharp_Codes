namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * getters & setters = add security to fields by encapsulation
             *                     They're accessors found within properties
             * properties = combine aspects of both fields and methods (share name with a field)
             * get accessor = used to return the property value
             * get accessor = used to assign a new value
             * value keyword = defines the value being assigned by the set (parameter)
             */

            Car car = new Car(400);

            car.Speed = 1000;

            Console.WriteLine(car.Speed);

            // Auto-Implemented properties = shortcut when no additional logic is requiered in the property
            //                               you do not have to define a field for a property,
            //                               you only have to write get; and/or set; inside the property


            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set 
            { 
                if (value > 500) 
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }

            }
        }
    }
}