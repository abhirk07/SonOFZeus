using System;

namespace Odd
{
    class oddeven
    {
        public static void Main16(string[] args)
        {
            int oddSum =0;
            int evenSum=0;
            int i=0;
            System.Console.WriteLine("Odd numbers");

            for(i=1; i<10;i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                     oddSum+=i;
                }

            }
                       
            System.Console.WriteLine("Odd Sum {0}",oddSum);
            System.Console.WriteLine("\n");
            
            System.Console.WriteLine("Even Numbers");

            for(int j=2;j<10;j++)
            {
                if(j % 2 ==0)
                {
                    System.Console.WriteLine(j);
                    evenSum+=j;
                }
            }
            System.Console.WriteLine("Even Sum is {0}",evenSum);
            
        }
    }
}