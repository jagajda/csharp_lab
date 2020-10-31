using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w skali Celsjusza, która poddana zostanie kkonwersji");
            float readTemp = float.Parse(Console.ReadLine());
            converter(readTemp);
            Console.ReadKey();
        }
        static void converter(float tempInCels)
        {
            Console.WriteLine("Temperatura w skali Kelwina= {0}", tempInCels + 273);
            Console.WriteLine("Temperatura w skali Fahrenheita= {0}", tempInCels * 18/10 + 32);
        }
    }
}
