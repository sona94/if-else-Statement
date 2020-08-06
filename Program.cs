
using System;

namespace If_else_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello");
            if(20 < 32)
            {
                Console.WriteLine("20 is less than 32");
            }

            int x = 12;
            int y = 20;
            if (x<y)
            {
                Console.WriteLine("12 is less than 20");
            }

            int time = 18;
            if(time> 20)
            {
                Console.WriteLine("Its not true.");
            }
            else
            {
                Console.WriteLine("Its true.");
            }
            int time1 = 22;
            if(time1 <10) //22<10 False 
            {
                Console.WriteLine("22 is less than 10 is wrong");
            }
            else if(time1 > 30) // 22> 30 False
            {
                Console.WriteLine("22 is less than 30 is right");
            }
            else
            {
                Console.WriteLine("Its equal to.");
            }
        }
    }
}
