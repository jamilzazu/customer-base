using CustomerBase.Domain.Core.Commands;
using CustomerBase.Domain.Core.Events;

namespace CustomerBase.Domain.Core.Bus
{
    public interface IBus
    {
        void SendComman<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
