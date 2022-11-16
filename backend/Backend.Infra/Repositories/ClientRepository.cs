using Backend.Domain.Interfaces;
using Backend.Domain.Entities;

namespace Backend.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly List<Client> _clients;

        public ClientRepository()
        {
            _clients = new List<Client>();
        }

        public Task<bool> Insert(Client entity)
        {
            _clients.Add(entity);

            return Task.FromResult(true);


        }
        public bool Update(Client entity)
        {
            var newClient = _clients.Find(c => c.Id == entity.Id);

            _clients.Remove(newClient);

            _clients.Add(entity);

            return true;

        }
        public bool Delete(int id)
        {
            var entity = _clients.Find(c => c.Id == id);
            _clients.Remove(entity);

            return true;
        }
        public bool Exists(int id)
        {
            return _clients.Any(c => c.Id == id);
        }
        public Task<List<Client>> GetAll()
        {
            return Task.FromResult(_clients);
        }
        public Task<Client> GetByName(string name)
        {
            return Task.FromResult(_clients.Find(c => c.Name == name));
        }
    }
}