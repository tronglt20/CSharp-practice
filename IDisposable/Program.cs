using System;

namespace Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var a = new A())
            {
                Console.WriteLine("Do something ...");
            }
        }
    }
}
