using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podane liczby to: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("Wynik iloczynu 3 liczb to: {0}", firstNumber * secondNumber * thirdNumber);
        }
    }
}
