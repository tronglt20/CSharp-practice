using System;

namespace AnonymousType_DynamicType
{
     class Program
    {
        static void Main(string[] args)
        {
            var TanTrong = new
            {
                name = "Trong",
                age = 21,
            };


            TestAnonymousType(TanTrong);
        }

       
        public static void TestAnonymousType(dynamic obj)
        {
            Console.WriteLine(obj.name);// ở thời điểm biên dịch - không biết obj có thuộc tính name hay không, nhưng nó vẫn biên dịch
        
        }
    }
}
