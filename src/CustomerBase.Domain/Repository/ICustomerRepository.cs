using CustomerBase.Domain.Entities;
using CustomerBase.Domain.Interfaces;

namespace CustomerBase.Domain.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
