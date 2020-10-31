using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex1
{
    public struct Point2D
    {
        public double x;
        public double y;

        public Point2D(double coordx, double coordy)
        {
            x = coordx;
            y = coordy;
        }

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

    class Program
    {
        static public bool IsInside(Point2D point, Point2D[] points, double radius)
        {
            foreach (Point2D p in points)
            {
                if (p.Dist(point) < radius)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            const double rad = 3.14;
            Console.WriteLine("Wprowadź współrzędną x");
            double coordx = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź współrzędną y");
            double coordy = Double.Parse(Console.ReadLine());
            Point2D p1 = new Point2D(coordx, coordy);
            Console.WriteLine("Wprowadź współrzędną x");
            coordx = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź współrzędną y");
            coordy = Double.Parse(Console.ReadLine());
            Point2D p2 = new Point2D(coordx,coordy);
            Console.WriteLine("Wprowadź współrzędną x");
            coordx = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź współrzędną y");
            coordy = Double.Parse(Console.ReadLine());
            Point2D p3 = new Point2D(coordx, coordy);
            Console.WriteLine("Wprowadź współrzędną x");
            coordx = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź współrzędną y");
            coordy = Double.Parse(Console.ReadLine());
            Point2D p4 = new Point2D(coordx, coordy);
            Console.WriteLine("Wprowadź współrzędną x");
            coordx = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź współrzędną y");
            coordy = Double.Parse(Console.ReadLine());
            Point2D p5 = new Point2D(coordx, coordy);

            Console.WriteLine("Dystans pomiędzy punktami= {0}", p1.Dist(p2));

            Console.WriteLine("Sprawdzam czy 5 punkt znajduje się wewnątrz któregokolwiek koła");
            Point2D[] points = new Point2D[4] { p1, p2, p3, p4};
            while (!IsInside(p5, points, rad))
            {
                Console.WriteLine("Podany punkt nie należy do żadnego z okręgów");
                double minDist = points[0].Dist(p5);
                foreach (Point2D p in points)
                {
                    if (p5.Dist(p) < minDist)
                    {
                        minDist = p5.Dist(p);
                    }
                }
                Console.WriteLine("Dystans do najbliższego punktu= {0}", minDist);
                Console.WriteLine("Wprowadź współrzędną x");
                coordx = Double.Parse(Console.ReadLine());
                Console.WriteLine("Wprowadź współrzędną y");
                coordy = Double.Parse(Console.ReadLine());
                if (coordx >= 0)
                {
                    p5.x = coordx;
                }
                else
                {
                    Console.WriteLine("Wprowadzono ujemną współrzędną");
                    break;
                }
                if (coordy >= 0)
                {
                    p5.y = coordy;
                }
                else
                {
                    Console.WriteLine("Wprowadzono ujemną współrzędną");
                    break;
                }

            }
            Console.WriteLine("Zakończono wprowadzanie danych, wypisuje współrzędne punktów");
            foreach (Point2D p in points)
            {
                p.Print2DPoint();
            }
            p5.Print2DPoint();

        }
    }
}
