using DiceThrower.Implementations;
using DiceThrower.Interfaces;

namespace DiceThrower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDice die1;
            //IDice die2;

            //die1 = new D20();
            //Console.WriteLine($"The number on die 1 is { die1.Throw() }.");

            //die2 = new D6();
            //Console.WriteLine($"The number on die 2 is { die2.Throw() }.");

            Console.WriteLine("Pick a dice, please.");
            var readString = Console.ReadLine();
            IDice anyDice = null;

            if (readString == "20")
            {
                anyDice = new D20();
            }
            else if (readString == "6")
            {
                anyDice = new D6();
            }
            else if (readString == "cheatD20")
            {
                anyDice = new LoadedD20();
            }
            else
            {
                Console.WriteLine("This die doesn't exist.");
                Environment.Exit(1);
            }

            Console.WriteLine($"The number on the die is { anyDice.Throw() }.");
        }
    }
}