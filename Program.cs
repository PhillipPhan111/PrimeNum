using System;

namespace ConsoleApp1
{
    class Program

    {
    static void Main(string[] args)
    {
        int prime = 0;
        for (int i = 2; prime < 1000; i++)
        {
            int x = 0;
            for (int j = 2; j < 1000; j++)
            {
                if ((i % j == 0) && (i != j))
                {
                    x = x + 1;
                }

            }

            if (x == 0)
            {
                Console.WriteLine(i);
                prime = prime + 1;
            }
        }
    }
    }
}
