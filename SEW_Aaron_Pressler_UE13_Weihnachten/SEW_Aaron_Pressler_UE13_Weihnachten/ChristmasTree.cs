using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SEW_Aaron_Pressler_UE13_Weihnachten
{
    class ChristmasTree
    {

       private void DrawChristmasTree(int height)
        {
            Random random = new Random();


            for (int i = 0; i < height; i++)
            {
                for (int blank = height - 1 - i; blank > 0; blank--)
                    {
                        Console.Write(" ");
                    }
                   
                for (int stars = i*2+1; stars > 0; stars--)
                {
                    int zufall = random.Next(0, 4);
                    for (int x = zufall; x > 0 && stars > 1; x--)
                    {
                        stars--;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                    Console.ForegroundColor = (ConsoleColor)random.Next(3, 11);
                    Console.Write("*");

                }
                Console.WriteLine();
                
            }

            for (int Stamm = height /3; Stamm > 0 ; Stamm--)
            {
                
                for (int blank = height-height/6-1; blank > 0; blank--)
                {
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int sterne = height/3; sterne > 0; sterne--)
                {
                    
                    Console.Write("*");
                    
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
            }
            Console.WriteLine("\t\t\t\tMERRY CHRISTMAS");
        }

        public void Run()
        {
            int height;
            Console.WriteLine("Geben Sie die Höhe des Baumes an");
            while (!int.TryParse(Console.ReadLine(), out height))

            {
                Console.WriteLine("Geben Sie eine Zahl ein!");
            }


            while (true)
            {
                Console.Clear();
                DrawChristmasTree(height);
                Thread.Sleep(1000);
            }

        }
    }

}
