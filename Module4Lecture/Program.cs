using System;

namespace Module4Lecture
{
    class Program
    {
        public void Loop()
        {
            for (int rows = 0; rows < 7; rows++)
            {
                for (int stars = 0; stars <= rows; stars++)
                {
                    Console.Write($"*"); // *
                }

                Console.WriteLine();
            }
        }


        public void LoopLab()
        {
            for (int rows = 0; rows < 7; rows++)
            {
                for (int hash = 0; hash <= rows; hash++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write($"#"); // *
                }

                Console.WriteLine();
            }
        }

        public void TableLoops()
        {
            const int ROWS = 4;
            const int COLS = 4;
            for (int row = 1; row <= ROWS; row++)
            {
                for (int col = 1; col <= COLS; col++)
                {
                    Console.Write((row * col) + " ");
                }

                Console.WriteLine();
            }
        }

        public void NestedLoops()
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine(hours + ":" + minutes);
                }
            }
        }

        public void RunningTotal2()
        {
            int count = 0;
            int total = 0;
            int amount = 0;

            Console.Write("Enter Sales Amount or -1 to exit");
            Int32.TryParse(Console.ReadLine(), out amount);

            while (amount != -1)
            {
                total += amount;
                count++;
                Console.Write("Enter Sales Amount");
                Int32.TryParse(Console.ReadLine(), out amount);
            }

            Console.WriteLine($"Your total is {total:C}");
            Console.WriteLine($"Your average is {total / (double) count}");
        }

        public void RunningTotal()
        {
            int total = 0;
            int amount = 0;

            Console.Write("Enter Sales Amount");
            Int32.TryParse(Console.ReadLine(), out amount);

            while (amount != -1)
            {
                total += amount;
                Console.Write("Enter Sales Amount");
                Int32.TryParse(Console.ReadLine(), out amount);
            }

            Console.WriteLine($"Your total is {total:C}");
        }

        public void FirstTryItOut()
        {
            /* loop displays even numbers between 2 and 10 incldue 2 and 10
             loop displays all numbers between 11 and 34 includiong 11 & 34
             loop displays all number between 56 and 3, inclusive, counting backwwards
        
             * if i is already created you can do for (i;-;-;) or for (; -; -;)
             */
            for (int i = 2; i <= 10; i += 2)
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


        public void Star()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        
        public void Star2()
        {
            Console.WriteLine("Enter width");
            int width = 0;
            Int32.TryParse(Console.ReadLine(), out width);
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void RandomTester()
        {
            Random randomNumGen = new Random();
            int count = 0;
            while (true)
            {
                // Infinite loop??

                double randomNum = randomNumGen.NextDouble();
                if (randomNum < 0.1) break; // Break out of the loop!
                else count++;
            }

            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.FirstTryItOut();
            // p.RunningTotal();
            // p.RunningTotal2();
            // p.NestedLoops();
            //p.TableLoops();
            // p.Loop();
            //p.Star();
            p.Star2();
            //p.RandomTester();
        }
    }
}