using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int m = 15;
            for (int n = 3; n <=m ; n++)
            {
               
                if (n % 7 ==0 )
                {

                    count++;
                    
                }
                


            }
            Console.WriteLine("Bu araliqda 7 e bolunen ededlerin sayi: = " + count);






        }
    }
}
