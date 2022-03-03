using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 200; i++)
            {
               
                if (i % 7 ==0 )
                {

                    count++;
                    
                }
                


            }
            Console.WriteLine("Bu araliqda 7 e bolunen ededlerin sayi: = " + count);






        }
    }
}
