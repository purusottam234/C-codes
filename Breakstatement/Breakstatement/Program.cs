using System;

namespace Breakstatement
{
    class Program
    {
        static void Main(string[] args)
        { 
            for(int  i = 1; i<100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(" Press any key to exit");
            Console.ReadKey();
        }
    }
}
