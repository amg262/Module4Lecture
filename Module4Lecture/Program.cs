using System;

namespace Module4Lecture
{
    class Program
    {
        static void Main(string[] args)
        {

            /* loop displays even numbers between 2 and 10 incldue 2 and 10
             loop displays all numbers between 11 and 34 includiong 11 & 34
             loop displays all number between 56 and 3, inclusive, counting backwwards
             */
            
            /*
             * if i is already created you can do for (i;-;-;) or for (; -; -;)
             */
            for (int i = 2; i <= 10; i+= 2)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 11; i <= 34; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 56; i >= 3; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}