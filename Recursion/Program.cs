using System;

namespace Recursion
{
    class Program
    {
        //Recursia 1
        static void Rec(int i)
        {
            Console.WriteLine(i);
            if (i >= 10)
                 return;
            i++;
            Rec(i);
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Recursion is in process");
            Rec(0);
        }


    }
}
