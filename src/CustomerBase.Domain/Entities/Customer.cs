using CustomerBase.Domain.Core.Models;

namespace CustomerBase.Domain.Entities
{
    public class Customer : Entity<Customer>
    {
        public Customer(string name, string document, string email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
        }

        private Customer() { }

        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Status { get; private set; }

        public override bool EhValido()
        {
            throw new System.NotImplementedException();
        }
    }
}
