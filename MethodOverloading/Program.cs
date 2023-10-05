using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); 
            string result = program.Add(1, 1, true);
            Console.WriteLine($"{result}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public string Add(int a, int b, bool includeDollars)
        {
            if (includeDollars)
            {
                string plural = (a + b == 1) ? "" : "s";
                return $"{a + b} dollar{plural}";
            }
            else
            {
                return (a + b).ToString();
            }
        }
    }
}
