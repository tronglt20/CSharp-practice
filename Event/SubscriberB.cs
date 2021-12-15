using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class SubscriberB
    {
        public void Sub(Publisher p)
        {
            p.event_news += null;
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine($"SubscriberB: {data.ToString()}");
        }
    }
}
