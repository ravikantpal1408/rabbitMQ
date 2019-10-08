using System;

namespace MicroRabbit.Domain.Core.Event
{
    // this is our base entity - will not implement and other interface or class
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}