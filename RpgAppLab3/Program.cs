using System;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();
            if (command == "roll D20")
            {

                var diceRoll = rnd.Next(20) + 1;
            Console.WriteLine($"Your dice roll is: {diceRoll}");
            }
            {
                var allNames = new[] { "Briana", "Ben",

                    "David", "Dana", "Felicia", "Felix", "Legolas, lskfj" };

                    

                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey(); }
    }
}
