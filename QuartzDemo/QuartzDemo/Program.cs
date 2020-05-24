using System;

namespace QuartzDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTask.StartTestAsync().GetAwaiter();

            Console.ReadKey();
        }
    }
}
