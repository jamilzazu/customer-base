using CustomerBase.Domain.Core.Commands;
using System;

namespace CustomerBase.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
