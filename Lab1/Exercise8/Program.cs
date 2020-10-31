using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Returned value = {0}", ( (firstNumber < 0 && secondNumber >= 0)  || (firstNumber >=0 && secondNumber < 0)));
        }
    }
}
