using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class SubscriberA
    {
        public void Sub(Publisher p) {
            p.event_news += ReceiverFromPublisher;
        }
      
        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine($"SubscriberA: {data.ToString()}");
        }
    }
}
