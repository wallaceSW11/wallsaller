using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces;

namespace Backend.Infra
{
    public class ClientRepository : IRepository<Client>
    {
        private readonly List<Client> _clients;

        public ClientRepository()
        {
            _clients = new List<Client>();
        }

        public void Insert(T entity)
        {
            _clients.Add(entity);
        }
        public void Update(T entity)
        {
            var newClient = _clients.Find(entity);

            _clients.Remove(newClient);

            _clients.Add(entity);

        }
        public void Delete(T entity)
        {
            _clients.Remove(entity);
        }
        public bool Exists(int id)
        {
            return _clients.Find(c => c.id == id);
        }
        public Task<IEnumerable<T>> GetAll()
        {
            return _clients.FindAll().ToList();
        }
        public Task<T> GetById(int id)
        {
            return _clients.Find(c => c.id == id);
        }
    }
}