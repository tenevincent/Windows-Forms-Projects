using EventAggregatorCore.Events;
using System;

namespace EventAggratorApp
{
    public class Class1
    {
        public Class1()
        {

            IEventAggregator eventS = new EventAggregator();
            
            // eventS.GetEvent<MessageEvent>().Publish

        }
    }

    public class MessageEvent : PubSubEvent<string>
    {

    }
}
