using CustomerBase.Domain.Core.Commands;
using CustomerBase.Domain.Interfaces;
using CustomerBase.Infra.Data.Context;

namespace CustomerBase.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerContext _context;

        public UnitOfWork(CustomerContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
