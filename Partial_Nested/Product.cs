using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Nested
{
    public partial class Product
    {
        public void LogProduct(string product)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{product}");
            Console.ResetColor();
        }

        
    }
}
