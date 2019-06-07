using CustomerBase.Domain.Core.Events;
using System;

namespace CustomerBase.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public DomainNotification(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
            Version = 1;
        }

        public Guid DomainNotificationId { get; set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }
    }
}