using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var task = GetWeb("https://xuanthulab.net/");

            /* var t4 = T4();
             var t5 = T5();

             var kq4 = await t4;
             var kq5 = await t5;

             Console.WriteLine(kq4);
             Console.WriteLine(kq5);*/


            /*Task t2 = T2();
            Task t3 = T3();

            await t2;
            await t3;*/

            DoSomething(5, "T1", ConsoleColor.Red); // Thread

            var content = await task;
            Console.WriteLine(content);

            Console.WriteLine("Press any key!");

            Console.ReadKey();
        }

        static async Task<string> GetWeb(string url) {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine("Get url ....");
            HttpResponseMessage message =  await httpClient.GetAsync(url);
            Console.WriteLine("Read url ....");
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine("Return content ....");
            return content;
        }

        static async Task<string> T4() {
            Task<string> t4 = new Task<String>(() =>
            {
                DoSomething(7, "T4", ConsoleColor.Cyan);
                return "Return from T4";
            });

            t4.Start();
            var kq = await t4;

            return kq;
        }

        static async Task<string> T5() {
            Task<string> t5 = new Task<String>((Object ob) => {
                var taskName = ob.ToString();
                DoSomething(10, taskName, ConsoleColor.DarkBlue);
                return $"Return from {taskName}";
            }, "T5");

            t5.Start();
            var kq = await t5;

            return kq;
        }

        static async Task T2()
        {
            Task T2 = new Task(() =>
            {
                DoSomething(3, "T2", ConsoleColor.Green);
            });

            T2.Start();
            await T2;

            Console.WriteLine("T2 hoan thanh");

        }

        static async Task T3()
        {
            Task T3 = new Task((Object obj) => {

                var taskName = obj.ToString();
                DoSomething(7, taskName, ConsoleColor.Yellow);
            }, "T3");

            T3.Start();
            await T3;
            Console.WriteLine("T3 hoan thanh");

        }


        static void DoSomething(int times, string mes, ConsoleColor color)
        {

            Console.ForegroundColor = color;
            Console.WriteLine($"{mes} ... start");
            Console.ResetColor();

            for (int i = 1; i <= times; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mes} {i}");
                Console.ResetColor();
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = color;
            Console.WriteLine($"{mes} ... end");
            Console.ResetColor();
        }
    }
}
