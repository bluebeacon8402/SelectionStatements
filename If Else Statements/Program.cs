using System;

namespace If_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());
            if(userInput < favNumber) { Console.WriteLine("too low");}
            else if(userInput > favNumber) { Console.WriteLine("too high");}
            else { Console.WriteLine("nevermind"); }

            Console.WriteLine("What is your favorite subject?");
            var favSub = int.Parse(Console.ReadLine());
            switch (favSub)
            {
                case 0:
                    Console.WriteLine("Math");
                    break;
                case 1:
                    Console.WriteLine("History");
                    break;
                case 2:
                    Console.WriteLine("Science");
                    break;
                case 3:
                    Console.WriteLine("English");
                    break;
                case 4:
                    Console.WriteLine("Geography");
                    break; 
                case 5:
                    Console.WriteLine("Spanish");
                    break;
            }

        }
    }
}
