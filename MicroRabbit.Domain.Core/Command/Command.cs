using System;
using MicroRabbit.Domain.Core.Event;

namespace MicroRabbit.Domain.Core.Command
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}