using Backend.Domain.Interfaces;
using Backend.Domain.Entities;

namespace Backend.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _Customers;

        public CustomerRepository()
        {
            _Customers = new List<Customer>();
        }

        public Task<bool> Insert(Customer entity)
        {
            var count = _Customers.Count();

            entity.Id = _Customers.Count;
            _Customers.Add(entity);

            return Task.FromResult(count != _Customers.Count());


        }
        public bool Update(Customer entity)
        {
            var newCustomer = _Customers.Find(c => c.Id == entity.Id);

            _Customers.Remove(newCustomer);

            _Customers.Add(entity);

            return true;

        }
        public bool Delete(int id)
        {
            var entity = _Customers.Find(c => c.Id == id);

            if (entity == null) return false;

            _Customers.Remove(entity);

            return true;
        }
        public bool Exists(int id)
        {
            return _Customers.Any(c => c.Id == id);
        }
        public Task<Customer> GetByName(string name)
        {
            return Task.FromResult(_Customers.Find(c => c.Name == name));
        }

        public Task<Customer> GetById(int id)
        {
            return Task.FromResult(_Customers.Find(c => c.Id == id));
        }

        public Task<IEnumerable<Customer>> GetAll()
        {
            return Task.FromResult(_Customers.AsEnumerable());
        }
    }
}