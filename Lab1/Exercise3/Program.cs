using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszy numer: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź drugi numer: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Drugi numer: {0}\tPierwszy numer: {1}", secondNumber, firstNumber);
        }
    }
}
