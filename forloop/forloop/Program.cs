using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            bool isprime = false;
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) {  
                        isprime = true;
                        break; }
                }
                if (isprime == false)
                if (isprime == false)
                {
 
 
                    Console.WriteLine("{0}", j);
                }
                else
                {
                    isprime = false;
                }
                Console.ReadKey();
            }
        }
    }
}
