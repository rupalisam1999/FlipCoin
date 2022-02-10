using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomCheck = random.Next(0, 2);
            if (randomCheck == 0)
            {
                Console.WriteLine("HEAD");
            }
            else
            {
                Console.WriteLine("TAIL");

            }
        }
    }
} 
        
    

