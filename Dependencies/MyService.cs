using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencies
{
    public class MyService
    {
        public string data1 { get; set; }
        public string data2 { get; set; }

        private MyServiceOptions opts;

        public MyService(IOptions<MyServiceOptions> options)
        {
            opts = options.Value;
            data1 = opts.data1;
            data2 = opts.data2;
        }

        public void PrintData() => Console.WriteLine($"{data1} / {data2}");
    }
}
