using System;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            
            OddEven(n);
        }

        public static void OddEven(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("The number is even ", +n);
            }
            else
            {
                Console.WriteLine("The number is odd", +n);
            }
        }
    }
}
