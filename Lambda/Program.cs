using System;

namespace Lambda
{
    class Program
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        static void Main(string[] args)
        {

            // Biểu thức lambda còn gọi là biểu thức hàm nặc danh (Anonymous)
            Action<string> action;

            action = Log;
            action += (x) => { Console.WriteLine(x); }; // Bieu thuc lambda: (các_tham_số) => biểu_thức;

            action("Hello world");
        }
    }
}
