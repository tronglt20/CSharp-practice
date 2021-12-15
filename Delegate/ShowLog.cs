using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class ShowLog
    {

        public delegate void Show(string message);

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{message}");
            Console.ResetColor();

        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
            Console.ResetColor();

        }
        public static void TestLog()
        {
            Show show;

            show = Info;
            show += Warning;
            show += (x) => Console.WriteLine($"{x}");

            show("Hello world");
        }
       
    }
}
