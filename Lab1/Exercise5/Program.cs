using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź podstawę do narysowania znaku");
            var sign = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0}{0}{0}{0} ", sign);
            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("{0}    {0}", sign);
            }
            Console.WriteLine(" {0}{0}{0}{0} ", sign);
        }
    }
}
