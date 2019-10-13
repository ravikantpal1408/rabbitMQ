using MicroRabbit.Domain.Core.Event;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            Amount = amount;
            To = to;
            From = from;
        }

        public int From { get; private set; }
        public int To { get;private set; }
        public decimal Amount { get;private set; }
    }
}