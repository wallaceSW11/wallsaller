using Backend.Domain.Interfaces;
using Backend.Application.Commands;
using Backend.Application.Mappings;
using Backend.Application.Queries;
using Backend.Application.Queries.ViewModel;

namespace Backend.Application.Service
{
    public class ClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Insert(InsertClientCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            var entity = ClientMapper.ToEntity(command);

            return await _repository.Insert(entity);
        }

        public bool Update(UpdateClientCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            var entity = _repository.GetByName(command.Name).Result;

            if (entity == null)
            {
                throw new Exception($"Customer didn't found: {command.Name}");
            }

            entity.Name = command.Name;
            entity.PhoneNumber = command.PhoneNumber;

            return _repository.Update(entity);
        }

        public bool Delete(DeleteClientCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            return _repository.Delete(command.Id);
        }


        public async Task<ClientViewModel> GetByName(GetClientByNameQuery query)
        {
            query.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            var client = await _repository.GetByName(query.Name);

            return ClientMapper.ToResponse(client);
        }



    }
}