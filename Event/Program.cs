using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            SubscriberA a = new SubscriberA();
            SubscriberB b = new SubscriberB();

            a.Sub(p);
            b.Sub(p);

            p.Send();

        }
    }
}
