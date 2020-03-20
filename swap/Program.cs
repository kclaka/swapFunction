using System;

namespace swap
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            
            int temp = x;
            x = y;
            y = temp;

            
        }
        static void Main(string[] args)
        {
            int x = 4;
            int y = 6;

            Swap(ref x, ref y);


            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
