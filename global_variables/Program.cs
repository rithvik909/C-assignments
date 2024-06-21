using System;

namespace GlobalVariablesExample
{
    public static class Globals
    {
        public static int global1 = 0;
        public static string Global2 = "Hello, World!";
    }
}

namespace GlobalVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial Global Counter: " + Globals.global1);
            Console.WriteLine("Initial Global Message: " + Globals.Global2);

            Globals.global1++;
            Globals.Global2 = "Hello, C#!";

            Console.WriteLine("Updated Global Counter: " + Globals.global1);
            Console.WriteLine("Updated Global Message: " + Globals.Global2);

            AnotherClass.DoSomething();

            Console.WriteLine("Final Global Counter: " + Globals.global1);
        }
    }

    public class AnotherClass
    {
        public static void DoSomething()
        {
            Console.WriteLine("AnotherClass accessing Global Counter: " + Globals.global1);
            Globals.global1 += 10;
            Console.WriteLine("AnotherClass modified Global Counter: " + Globals.global1);
        }
    }
}