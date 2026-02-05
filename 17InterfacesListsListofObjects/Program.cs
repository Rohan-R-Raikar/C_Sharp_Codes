namespace InterfacesListsListofObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow
            //             An Interface declares "what a class should have"
            //             An Inheriting class defines "how it should do it"
            //             Benifit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

            String[] food = new string[3];
            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";

            foreach (string foodItem in food)
            {
                Console.WriteLine(foodItem);
            }

            List<String> Jevan = new List<String>();
            Jevan.Add("Pizza");
            Jevan.Add("Ham");
            Jevan.Add("Burger");
            Jevan.Add("Hotdog");
            Jevan.Add("Spagati");
            Jevan.Add("Sandwitch");
            Jevan.Add("Toast");

            foreach (string J in Jevan)
            {
                Console.WriteLine(J);
            }

            // List of Objects

            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(player1); 
            players.Add(player2); 
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }

            Console.ReadKey();
        }

        class Player
        {
            public String username;
            public Player(String username)
            {
                this.username = username;
            }
        }

        interface IPray
        {
            void Flee();
        }
        interface IPreditor
        {
            void Hunt();
        }

        class Rabbit : IPray
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk
        {
            public void Hunt()
            {
                Console.WriteLine("Hawk is searching for food!");
            }
        }

        class Fish : IPray, IPreditor
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}