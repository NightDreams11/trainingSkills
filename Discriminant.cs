using System;

namespace Discriminant
{
    class Program
    {
        static void Discriminant(int a, int b, int c)     //x = y^2+2y+1
        {
            double Discr = Math.Pow(b, 2) - 4 * a * c;
            if (Discr != 0 && Discr > 0)
            {
                double XOne = (-b + Math.Sqrt(Discr)) / (2 * a);
                double XSecond = (-b - Math.Sqrt(Discr)) / (2 * a);
                Console.WriteLine("Первый корень равен {0}, второй {1}.", XOne, XSecond);
            }
            else if (Discr == 0)
            {
                double XSecond = (-b - Math.Sqrt(Discr)) / (2 * a);
                Console.WriteLine("Корень равен {0}", XSecond);
            }
            else
            {
                Console.WriteLine("Решений нет, дискриминант равен {0}.", Discr);
            }
        }
        static void Main(string[] args)
        {
            Discriminant(1, 6, 9);
        }
    }
}
