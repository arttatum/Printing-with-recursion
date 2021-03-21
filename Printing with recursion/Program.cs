using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Printing_with_recursion
{
    class Program
    {
        static private long i, n;
        static private readonly Stopwatch timer = new Stopwatch();
        static private bool isToN;


        static void Main(string[] args)
        {
            // Collect inputs from user
            RunUi();

            // Perform count and print using recursion
            timer.Start();
            if(isToN)
            {
                i = 1;
                CountFromOne();
            }
            else
            {
                i = n;
                CountToOne();
            }

            Console.ReadKey();
        }

        private static void RunUi()
        {
            // Take inputs for counting type and N.
            Console.WriteLine("Hello user, \n\nThis console application can print the integers to or from integer N, without using any loops! \n(Okay I admit, I use loops to handle bad user input, but that's it, promise!)\n");

            Console.Write("First of all, would you like to count from 1 to N (A), or N to 1 (B)? \n\nPlease type your preference below, then hit enter.\n\n");

            string direction = Console.ReadLine();

            while (!string.Equals(direction, "a", StringComparison.OrdinalIgnoreCase) && !string.Equals(direction, "b", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Whoops, you have to enter 'A' or 'B' then hit enter. Please try again.\n");
                direction = Console.ReadLine();
            }

            isToN = direction.Equals("A", StringComparison.OrdinalIgnoreCase);

            string startOrEnd = isToN ? "end" : "start";

            Console.WriteLine($"\nThanks. Now I just need to know, what value of N would you like to {startOrEnd} counting at?\n");

            string nString = Console.ReadLine();

            while (!long.TryParse(nString, out n))
            {
                Console.WriteLine("\nWhoops, you have to enter an integer value? (I'll accept a long too)\n");
                nString = Console.ReadLine();
            }

            Console.WriteLine($"\nGreat, now for the grand finale, sit back and relax as I use recursion to count!\n");
        }

        private static void CountFromOne()
        {
            Task.Run(() =>
            {
                if (n > 0)
                {
                    if (i == n + 1)
                    {
                        Console.WriteLine($"\nCount finished in {timer.ElapsedMilliseconds}ms");
                        return;
                    }
                    Console.WriteLine(i);
                    i++;
                    CountFromOne();
                }
                else
                {
                    if (i == n - 1)
                    {
                        Console.WriteLine($"\nCount finished in {timer.ElapsedMilliseconds}ms");

                        return;
                    }
                    Console.WriteLine(i);
                    i--;
                    CountFromOne();
                }
            });
        }        

        private static void CountToOne()
        {
            Task.Run(() =>
            {
                if (n > 0)
                {
                    if (i == 0)
                    {
                        return;
                    }
                    Console.WriteLine(i);
                    i--;
                    CountToOne();
                }
                else
                {
                    if (i == 2)
                    {
                        return;
                    }
                    Console.WriteLine(i);
                    i++;
                    CountToOne();
                }
            });
        }
    }    
}
