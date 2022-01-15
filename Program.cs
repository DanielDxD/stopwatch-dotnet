using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds");
            Console.WriteLine("M = Minutes");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long do you want to count?");
        }
        static void Start(int time = 10)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Count completed...");
            Thread.Sleep(2500);
        }
    }
}
