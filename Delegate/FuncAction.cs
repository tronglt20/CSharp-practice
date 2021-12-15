using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class FuncAction
    {
        // Func method
        static int SumFunc(int a, int b)
        {
            var c = a + b;
        
            return c;
        }

        // Action method
        static void SumAction(int a, int b)
        {
            var c = a + b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum Action = {c}");
            Console.ResetColor();
        }


        public void Print(int result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum Func = {result}");
            Console.ResetColor();
        }

        public void TestFunc()
        {
            Func<int, int, int> FuncTinhTong;

            FuncTinhTong = SumFunc;

            var result = FuncTinhTong(2, 4);

            Print(result);


            Action<int, int> ActionTinhTong;

            ActionTinhTong = SumAction;
            ActionTinhTong += (int a, int b) => Console.WriteLine($"{a+b}");

            ActionTinhTong(2, 5);

        }

    }
}
