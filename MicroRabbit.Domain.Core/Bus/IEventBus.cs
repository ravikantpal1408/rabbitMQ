using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        // send any type of command
        Task SendCommand<T>(T command) where T : Command.Command;
        
        // enabling capability to publish any kind of event 
        void Publish<T>(T @event) where T : Event.Event;

        void Subscribe<T, TH>()
            where T : Event.Event
            where TH : IEventHandler<T>;
        
        

    }
}