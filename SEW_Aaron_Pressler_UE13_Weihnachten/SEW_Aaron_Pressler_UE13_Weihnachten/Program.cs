using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Aaron_Pressler_UE13_Weihnachten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            ChristmasTree ct = new ChristmasTree();
            ct.Run();
            Console.ReadLine();
        }
    }
}
