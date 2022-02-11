using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int heads = 0;
            for (int i = 0; i < 1000; i++) ;
            int randomCheck = random.Next(2);
            if (randomCheck == 0)
            {
                heads++;
            }
            {
                Console.WriteLine("Times head was flipped:" + heads);
            }
            
            {
                Console.WriteLine("Times tail was flipped:" + (1000 - heads));

            }
        }
    }
} 
        
    

