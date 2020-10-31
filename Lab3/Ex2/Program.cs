using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    /* Definicja do ćwiczenia 1 i 2 */
    public struct Point2D
    {
        //Próba inicjalizacji pól struktury
        private double x = 1;
        private double y = 2;

        public Point2D(double coordx, double coordy)
        {
            x = coordx;
            y = coordy;
        }

        //Próba zdefiniowania konstruktora bez parametrów
        public Point2D()
        { }
        public void Reset()
        {
            x = 0;
            y = 0;
        }

        public void IncrX(double dx)
        {
            x += dx;
        }

        public void IncrY(double dy)
        {
            y += dy;
        }

        public void Print2DPoint()
        {
            Console.WriteLine("Coord x={0}, coord y={1}", x, y);
        }

        public double Dist(Point2D p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }
    }
    /* enum do ćwiczenia 3 */
    public enum Dni { poniedziałek=1, wtorek, środa, czwartek, piątek, sobota, niedziela }

    /* enum do ćwiczenia 4 */
    public enum Zakres { maly=10, sredni=99, duzy=100 }

    /* Definicje do ćwiczenia 8 */
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    class Program
    {

        /* Implementacja ćwiczenia 2 */
        static void Exercise2()
        {
            //Próba wywołania metody bez konstruktora
            Point2D p1 = new Point2D(1, 2);
            p1.ToString();

        }

        /* implementacja ćwiczenia 3 */
        static void Exercise3()
        {
            int floatsConv = 0;
            int stringConv = 0;
            int intConv = 0;
            int resultI = 0;
            float resultF = .0f;
            string resultS = "";
            string read = "";
            bool status = false;
            Console.WriteLine("Wprowadź pierwszy tekst do konwersji");
            read = Console.ReadLine();
            while (resultI != -1)
            {
                Console.WriteLine("Wprowadź tekst do konwersji");
                read = Console.ReadLine();
                if (int.TryParse(read, out resultI))
                {
                    intConv++;
                }
                else if (float.TryParse(read, out resultF))
                {
                    floatsConv++;
                }
                else
                {
                    resultS = read;
                    stringConv++;
                }
                status = int.TryParse(read, out resultI);
            }
            Console.WriteLine("Dokonano konwersji: int= {0}, float={1}, string={2}", intConv, floatsConv, stringConv);
        }

        /* Implementacja ćwiczenie 4_1 */
        static void Exercise4_1()
        {
            Console.WriteLine("Podaj liczbę reprezentującą dzień tygodnia, który ma zostać wypisany");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podany dzień tygodnia to {0}", Enum.GetName(typeof(Dni), day));
            
        }

        /* Implementacja ćwiczenia 4_2 */
        static void Exercise4_2()
        {
            Console.WriteLine("Podaj liczbę a program sprawdzi czy liczba jest mala, srednia czy duża");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < (int)Zakres.maly)
            {
                Console.WriteLine("Podana liczba znajduje się w kategorii: {0}", Enum.GetName(typeof(Zakres), 10));
            }
            else if (number >= (int)Zakres.maly && number < (int)Zakres.duzy)
            {
                Console.WriteLine("Podana liczba znajduje się w kategorii: {0}", Enum.GetName(typeof(Zakres), 99));
            }
            else
            {
                Console.WriteLine("Podana liczna znajduje się w kategorii: {0}", Enum.GetName(typeof(Zakres), 100));
            }
        }

        /* Implementacja ćwiczenia 5 */
        static void Exercise5()
        {
            char[] samogłoski = new char[] { 'a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y' };
            Console.WriteLine("Podaj znak");
            char znak = char.Parse(Console.ReadLine());
            if (samogłoski.Contains(znak))
            {
                Console.WriteLine("Podany znak jest samogłoską");
            }
            else if (Char.IsNumber(znak))
            {
                Console.WriteLine("Podany znak jest cyfrą");
            }
            else 
            {
                Console.WriteLine("Podany znak nie należy do żadnej z kategorii");
            }
        }

        /* Implementacja ćwiczenia 6 */
        static void Exercise6()
        {
            Console.WriteLine("Podaj łańcuch znaków, który zostanie przetworzony");
            string input = Console.ReadLine();
            Console.WriteLine("Litery, z których składa się \"{0}\":", input);
            foreach (var ch in input)
            {
                Console.Write("'{0}' ", ch.ToString());
            }
        }

        /* Implementacja ćwiczenia 7 */
        static void Exercise7()
        {
            try
            {
                int overflown = Int32.MaxValue;
                checked
                {
                    overflown++;
                }
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("Exception {0} caught", ex.GetType());
            }
         
        }

        /* Implementacja ćwiczenia 8 */
        static void Fun1(Point p1)
        {
            p1.x += 1;
            p1.y += 2;
        }

        static void Fun2(Coords c1)
        {
            c1.x += 1;
            c1.y += 2;
        }

        /* Implementacja ćwiczenia 8 - część 1 */
        static void Exercise8_1()
        {
            Point point1 = new Point(2, 2);
            Coords coord1 = new Coords(2, 2);
            Console.WriteLine("Wartości współrzędnych obiektu klasy przed wywołaniem funckji: {0}, {1}", point1.x, point1.y);
            Console.WriteLine("Wartości współrzędnych obiektu struktury przed wywołaniem funckji: {0}, {1}", point1.x, point1.y);
            Fun1(point1);
            Fun2(coord1);
            Console.WriteLine("Wartości współrzędnych obiektu klasy po wywołaniu funkcji: {0}, {1}", point1.x, point1.y);
            Console.WriteLine("Wartości współrzędnych obiektu struktury po wywołaniu funkcji: {0}, {1}", coord1.x, coord1.y);
        }

        /* Implementacja ćwiczenia 8 - część 2 */
        static void Exercise8_2()
        {
            Point point1 = new Point(2, 2);
            Point point2 = new Point(3, 3);

            Coords coord1 = new Coords(2, 2);
            Coords coord2 = new Coords(3, 3);

            Console.WriteLine("Porównanie pierwszej pary");
            Console.WriteLine("a.Object. Equals (.., ..)); {0}", Object.Equals(point1, coord1));
            Console.WriteLine("b.p.Equals(...) - metoda obiektu Point; {0}", point1.Equals(coord1));
            Console.WriteLine("c.c.Equals(...) - metoda obiektu Coords; {0}", coord1.Equals(point1));
            Console.WriteLine("d.Object. ReferenceEquals (a, b); {0}", Object.ReferenceEquals(point1, coord1));

            Console.WriteLine("Porównanie drugiej pary");
            Console.WriteLine("a.Object. Equals (.., ..)); {0}", Object.Equals(point2, coord2));
            Console.WriteLine("b.p.Equals(...) - metoda obiektu Point; {0}", point2.Equals(coord2));
            Console.WriteLine("c.c.Equals(...) - metoda obiektu Coords; {0}", coord2.Equals(point2));
            Console.WriteLine("d.Object. ReferenceEquals (a, b); {0}", Object.ReferenceEquals(point2, coord2));
        }

        /* Implementacja ćwiczenia 9(prosty kalkulator) */
        static void Exercise9()
        {
            bool res = true;
            string input = default(string);
            int converted = default(int);
            List<int> arguments = new List<int>();
            int finalResult = default(int);
            List<char> operators = new List<char>();
            char[] separators = new char[] { '+', '-' };
            char currOperator = default(char);

            string[] inputSplitted = new string[] { };
            Console.WriteLine("Podaj wyrażenie do przetworzenia");
            input = Console.ReadLine();
            while (res)
            {
                arguments.Clear();
                operators.Clear();
                inputSplitted = input.Split(separators);
                foreach (var i in inputSplitted)
                {
                    res = Int32.TryParse(i, out converted);
                    arguments.Add(converted);
                }
                foreach (var c in input)
                {
                    if (!Char.IsNumber(c) && (c == '+' || c == '-'))
                    {
                        operators.Add(c);
                    }
                    else if (Char.IsNumber(c))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wprowadzono nieobsługiwany znak");
                        System.Environment.Exit(1);
                    }
                }
                finalResult = arguments.First();
                arguments.Remove(arguments.First());
                foreach (int val in arguments)
                {
                    if (operators.Count > 0)
                    {
                        currOperator = operators.First();
                        operators.Remove(operators.First());
                    }
                    switch (currOperator)
                    {
                        case '+':
                            finalResult += val;
                            continue;
                        case '-':
                            finalResult -= val;
                            continue;
                        default:
                            break;
                    }
                }
                Console.WriteLine("Oto wynik= {0}", finalResult);
                finalResult = 0;
                Console.WriteLine("Wprowadź kolejne wyrażenie:");
                input = Console.ReadLine();
            }
        }

        /* Implementacja ćwiczenia 10 */
        static void Exercise10()
        {
            byte valByte = 16;
            short valShort = 16;
            int valInt = 16;
            long valLong = 16;
            ulong valLLong = 16;
            //Konwersja niejawna byte -> short
            valShort = valByte;
            //Konwersja niejawna short -> int
            valInt = valShort;
            float fl = 2.2f;
            //Konwersja niejawna float -> double
            double flD = fl;
            UInt16 val16 = 1;
            //Konwersja niejawna UInt16 -> Uint64
            UInt64 val64 = val16;

            //Konwersje jawne
            uint uintVal = (uint)valInt;
            float floatVal = (float)valInt;
            byte byteVal = (byte)valLong;
            double doubleVal = (double)valLLong;
            
        }

        static void Main(string[] args)
        {
            Exercise8_2();
        }
    }
}
