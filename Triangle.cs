using System;
//Write a C# Sharp program that takes a 
//number and a width also a number, as input and then displays a 
//triangle of that width, using that number.
namespace Triangle
{
    class Program
    {
        static void Triangle(int value1)
        {
            int height = value1;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Triangle2(int value1)
        {
            int height = value1;

            for (int i = value1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void Triangle3(int value1)
        {
            int height = value1;

            for (int i = value1; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = value1; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }

        }
        static void Triangle4(int value1)
        {
            int height = value1;

            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = value1 - 1; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Triangle(5);
            Console.WriteLine("------");
            Triangle2(5);
            Console.WriteLine("------");
            Triangle3(5);
            Console.WriteLine("------");
            Triangle4(5);
        }
    }
}



        
            


                
        


