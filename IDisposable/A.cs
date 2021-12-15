using System;
using System.Collections.Generic;
using System.Text;

namespace Disposable
{
    public class A : IDisposable
    {
        bool resource = true;
        public void Dispose()
        {
            Console.WriteLine("Phương thức này gọi tự động khi hết using");
            resource = false; // giải phóng tài nguyên
        }
    }
}
