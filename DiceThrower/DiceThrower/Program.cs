using DiceThrower.Implementations;
using DiceThrower.Interfaces;

namespace DiceThrower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDice die1;
            IDice die2;

            die1 = new D20();
            Console.WriteLine($"The number on die 1 is { die1.Throw() }.");

            die2 = new D6();
            Console.WriteLine($"The number on die 2 is { die2.Throw() }.");
        }
    }
}