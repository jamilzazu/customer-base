using CustomerBase.Domain.Core.Events;
using System;

namespace CustomerBase.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public Command()
        {
            Timestamp = DateTime.Now;
        }

    }
}
