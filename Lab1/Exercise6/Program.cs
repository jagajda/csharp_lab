using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ii = 75400;
            double id = 7.54;
            string s = string.Format("Wartość int to {0}, a wartość double to {1}", ii, id);
            Console.WriteLine("# Using string.Format()");
            Console.WriteLine(s);

            string s2 = "Wartość int to " + Convert.ToString(ii) + " , a wartość double to " + Convert.ToString(id);
            Console.WriteLine("# Using + operator and Convert.ToString()");
            Console.WriteLine(s2);

            Console.WriteLine("# Using formatters");
            Console.WriteLine("Wartość int to ---{0,-40}---, a wartość double to ---{1,40}---", ii, id);

            ii = 75300;
            id = 7.53;
            Console.WriteLine("# format");
            Console.WriteLine("{{:c}}\t{0:c}\t{1:c}", ii, id);
            Console.WriteLine("{{:d}}\t{0:d}", ii);
            Console.WriteLine("{{:e}}\t{0:e}\t{1:e}", ii, id);
            Console.WriteLine("{{:f}}\t{0:f}\t{1:f}", ii, id);
            Console.WriteLine("{{:r}}\t\t{0:r}", id);
            Console.WriteLine("{{:x}}\t{0:x}", ii);

            float flo = 220.022f;
            Console.WriteLine("# format");
            Console.WriteLine("{{:0.00000}}\t{0:0.00000}", flo);
            Console.WriteLine("{{:[#].(#) (##)}}\t{0:[#].(#)(##)}", flo);
            Console.WriteLine("{{:0.0,0}}\t{0:0,0}", flo);
            Console.WriteLine("{{:,.}}\t{0:,.}", flo);
            Console.WriteLine("{{:0%}}\t{0:0%}", flo);
            Console.WriteLine("{{:0e+0}}\t{0:0e+0}", flo);

            var liczba = 123.4;
            var liczba1 = -1234;
            var liczba2 = 0;
            Console.WriteLine("# Using {{0:#,##0.0;(#,##)Minus;Zero}} format");
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", liczba);
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", liczba1);
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", liczba2);

            DateTime d = System.DateTime.Now;
            Console.WriteLine("# format\tdate");
            Console.WriteLine("{{:d}}\t{0:d}", d);
            Console.WriteLine("{{:D}}\t{0:D}", d);
            Console.WriteLine("{{:t}}\t{0:t}", d);
            Console.WriteLine("{{:T}}\t{0:T}", d);
            Console.WriteLine("{{:f}}\t{0:f}", d);
            Console.WriteLine("{{:F}}\t{0:F}", d);
            Console.WriteLine("{{:g}}\t{0:g}", d);
            Console.WriteLine("{{:G}}\t{0:G}", d);
            Console.WriteLine("{{:M}}\t{0:M}", d);
            Console.WriteLine("{{:r}}\t{0:r}", d);
            Console.WriteLine("{{:s}}\t{0:s}", d);
            Console.WriteLine("{{:u}}\t{0:u}", d);
            Console.WriteLine("{{:U}}\t{0:U}", d);
            Console.WriteLine("{{:Y}}\t{0:Y}", d);
        }
    }
}
