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
            Console.WriteLine("S = Seconds -> 10s = 10 seconds");
            Console.WriteLine("M = Minutes -> 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long do you want to count?");

            string input = Console.ReadLine().ToLower();
            if (input == "0")
            {
                return;
            }
            char type = char.Parse(input.Substring(input.Length - 1, 1));
            int time = int.Parse(input.Substring(0, input.Length - 1));
            PreStart(type == 's' ? time : time * 60);
        }
        static void PreStart(int time = 10)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Start(int time)
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
            Menu();
        }
    }
}
