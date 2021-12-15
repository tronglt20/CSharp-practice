using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Nested
{
    public partial class Product
    {
        public void testLogProduct()
        {
            Action<String> test;
            test = LogProduct;
            test("Buoi");

            LogProduct("Chuoi");
        }
    }
}
