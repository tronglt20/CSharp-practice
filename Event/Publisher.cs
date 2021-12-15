using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class Publisher
    {
        public delegate void NotifyNews(object data);

        public event NotifyNews event_news;

        public void Send()
        {
            event_news?.Invoke("Tin tuc moi!!!");
        }
    }
}
